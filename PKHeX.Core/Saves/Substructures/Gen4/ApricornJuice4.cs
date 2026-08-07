using System;
using System.ComponentModel;
using static System.Buffers.Binary.BinaryPrimitives;

namespace PKHeX.Core;

/// <summary>
/// HG/SS Apricorn juice-making.
/// </summary>
/// <remarks>
/// size 0x84, at 0xE558 within <see cref="SAV4HGSS"/> General.
/// </remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ApricornJuice4(Memory<byte> Raw)
{
    public const int SIZE = 0x84;

    /// <summary>Number of taste sub-fields packed into <see cref="GetJuiceTaste"/><see cref="ApricornJuiceFlavor4"/></summary>
    public const int TasteSlotCount = 5;

    /// <summary>Number of apricorn hopper slots.</summary>
    public const int HopperSlotCount = 5;

    /// <summary>Max taste.</summary>
    public const byte MaxTaste = 63;

    /// <summary>Sentinel stored in a hopper slot (<see cref="GetHopperColor"/>) when it holds no apricorns.</summary>
    public const byte HopperEmpty = 7;

    /// <summary>Max for <see cref="JuiceRest"/></summary>
    public const byte CanonicalMaxJuiceUses = 3;

    /// <summary>Max for <see cref="MildnessCount"/></summary>
    public const uint CanonicalMaxMildness = 255;

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    private const int OfsJuiceRest = 0x09;
    private const int OfsStock = 0x0A;
    private const int OfsJuice = 0x0C;
    private const int OfsStartCt = 0x14;
    private const int OfsMildCt = 0x18;
    private const int OfsFooter = 0x1C;

    /// <summary>
    /// Servings remaining from the most recently completed batch of juice.
    /// </summary>
    public byte JuiceRest { get => Data[OfsJuiceRest]; set => Data[OfsJuiceRest] = value; }

    private ushort StockRaw
    {
        get => ReadUInt16LittleEndian(Data[OfsStock..]);
        set => WriteUInt16LittleEndian(Data[OfsStock..], value);
    }

    /// <summary>
    /// Apricorn color loaded into hopper slot <paramref name="index"/> (0-4 of <see cref="HopperSlotCount"/>),
    /// matching <see cref="Apricorn4Color"/>'s value range (0-6), or <see cref="HopperEmpty"/> (7) if unloaded.
    /// </summary>
    public byte GetHopperColor(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)HopperSlotCount);
        return (byte)((StockRaw >> (index * 3)) & 0x7);
    }

    public void SetHopperColor(int index, byte value)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)HopperSlotCount);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(value, HopperEmpty);
        int shift = index * 3;
        StockRaw = (ushort)((StockRaw & ~(0x7 << shift)) | (value << shift));
    }

    /// <summary>
    /// Set by the game when at least one hopper slot is loaded.
    /// </summary>
    public bool HasStock
    {
        get => (StockRaw & 0x8000) != 0;
        set => StockRaw = (ushort)((StockRaw & 0x7FFF) | (value ? 0x8000 : 0));
    }

    private ulong JuiceRaw
    {
        get => ReadUInt64LittleEndian(Data[OfsJuice..]);
        set => WriteUInt64LittleEndian(Data[OfsJuice..], value);
    }

    /// <summary>
    /// Taste level (0-63) for one of the five <see cref="ApricornJuiceFlavor4"/> slots of the juice
    /// currently being brewed (or most recently brewed).
    /// </summary>
    public byte GetJuiceTaste(ApricornJuiceFlavor4 flavor) => GetJuiceTaste((int)flavor);

    public byte GetJuiceTaste(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)TasteSlotCount);
        return (byte)((JuiceRaw >> (index * 6)) & 0x3F);
    }

    public void SetJuiceTaste(ApricornJuiceFlavor4 flavor, byte value) => SetJuiceTaste((int)flavor, value);

    public void SetJuiceTaste(int index, byte value)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)TasteSlotCount);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxTaste);
        int shift = index * 6;
        JuiceRaw = (JuiceRaw & ~((ulong)0x3F << shift)) | ((ulong)value << shift);
    }

    /// <summary>
    /// Step count snapshotted when the current juice batch started brewing.
    /// </summary>
    public uint BrewStartStepCount
    {
        get => ReadUInt32LittleEndian(Data[OfsStartCt..]);
        set => WriteUInt32LittleEndian(Data[OfsStartCt..], value);
    }

    /// <summary>
    /// Counter toward the batch's mildness bonus. Canonical range is 0-<see cref="CanonicalMaxMildness"/>
    /// </summary>
    public uint MildnessCount
    {
        get => ReadUInt32LittleEndian(Data[OfsMildCt..]);
        set => WriteUInt32LittleEndian(Data[OfsMildCt..], value);
    }

    private uint FooterRaw
    {
        get => ReadUInt32LittleEndian(Data[OfsFooter..]);
        set => WriteUInt32LittleEndian(Data[OfsFooter..], value);
    }

    /// <summary>
    /// Remaining step-count delta until the current juice batch finishes brewing.
    /// </summary>
    public uint StepsUntilDone
    {
        get => FooterRaw & 0x3FFF_FFFF;
        set => FooterRaw = (FooterRaw & 0xC000_0000) | (value & 0x3FFF_FFFF);
    }

    /// <summary>
    /// One-time startup message state.
    /// </summary>
    public ApricornJuiceStartupMessage4 StartupMessage
    {
        get => (ApricornJuiceStartupMessage4)(FooterRaw >> 30);
        set => FooterRaw = (FooterRaw & 0x3FFF_FFFF) | ((uint)value << 30);
    }
}
