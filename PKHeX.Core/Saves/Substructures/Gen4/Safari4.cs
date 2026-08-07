using System;
using System.ComponentModel;
using static System.Buffers.Binary.BinaryPrimitives;

namespace PKHeX.Core;

/// <summary>
/// HG/SS Safari Zone save data.
/// </summary>
/// <remarks>
/// size 0x5FC, at 0xC13C within <see cref="SAV4HGSS"/> General.
/// Decomp reference: <c>SAFARI_SAVE</c> in src/savedata/safari_sv.c
/// </remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Safari4(Memory<byte> Raw)
{
    public const int SIZE = 0x5FC;
    public const int LayoutCount = 2;

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    /// <summary>
    /// [0] is the player's own layout; [1] is a friend's layout received over communication.
    /// </summary>
    public SafariLayout4 GetLayout(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, LayoutCount);
        return new(Raw.Slice(index * SafariLayout4.SIZE, SafariLayout4.SIZE));
    }

    public SafariLayout4 LayoutSelf => GetLayout(0);
    public SafariLayout4 LayoutFriend => GetLayout(1);

    private const int OfsManager = LayoutCount * SafariLayout4.SIZE; // 0x5D0
    public SafariManager4 Manager => new(Raw.Slice(OfsManager, SafariManager4.SIZE));

    private const int OfsFooter = OfsManager + SafariManager4.SIZE; // 0x5F8

    /// <summary>
    /// Pending day-rollover level ups, applied when the player is not inside the Safari Zone.
    /// </summary>
    public byte LevelUpDelayCount { get => Data[OfsFooter]; set => Data[OfsFooter] = value; }

    // 0x5F9: u8 obj_level:6; u8 game_layout:2;

    /// <summary>
    /// Unlock level for placeable objects; raised over time by Baoba's calls.
    /// </summary>
    public byte ObjectLevel
    {
        get => (byte)(Data[OfsFooter + 1] & 0x3F);
        set => Data[OfsFooter + 1] = (byte)((Data[OfsFooter + 1] & 0xC0) | Math.Min(value, MaxObjectLevel));
    }

    /// <summary>
    /// Which layout index the game reads while the player is inside the Safari Zone.
    /// </summary>
    public byte GameLayout
    {
        get => (byte)((Data[OfsFooter + 1] >> 6) & 3);
        set => Data[OfsFooter + 1] = (byte)((Data[OfsFooter + 1] & 0x3F) | ((value & 3) << 6));
    }

    /// <summary>
    /// Play time (in minutes) snapshotted when the current object-unlock event started.
    /// </summary>
    public ushort EventKeyTime
    {
        get => ReadUInt16LittleEndian(Data[(OfsFooter + 2)..]);
        set => WriteUInt16LittleEndian(Data[(OfsFooter + 2)..], value);
    }

    /// <summary>Cap enforced by <c>SafariSv_ObjLevelSet</c>; confirm against safari_sys.h before shipping.</summary>
    public const byte MaxObjectLevel = 0x3F;
}

/// <summary>
/// One Safari Zone arrangement: the six placed areas plus the per-area-type day counters.
/// </summary>
/// <remarks>size 0x2E8</remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class SafariLayout4(Memory<byte> Raw)
{
    public const int SIZE = 0x2E8;
    public const int BlockCount = 6;
    public const int MapCount = 12; // SAFARI_MAP_MAX

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    public SafariBlock4 GetBlock(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, BlockCount);
        return new(Raw.Slice(index * SafariBlock4.SIZE, SafariBlock4.SIZE));
    }

    private const int OfsMapLevel = BlockCount * SafariBlock4.SIZE; // 0x2DC

    /// <summary>
    /// Days each area type has been placed, keyed by <see cref="SafariMap4"/>. Drives which species appear.
    /// </summary>
    public Span<byte> MapLevels => Data.Slice(OfsMapLevel, MapCount);

    public byte GetMapLevel(SafariMap4 map) => MapLevels[(int)map];
    public void SetMapLevel(SafariMap4 map, byte days) => MapLevels[(int)map] = days;

    public void SetAllMapLevels(byte days) => MapLevels.Fill(days);
}

/// <summary>
/// A single placed Safari area and the objects the player has arranged inside it.
/// </summary>
/// <remarks>size 0x7A</remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class SafariBlock4(Memory<byte> Raw)
{
    public const int SIZE = 0x7A;
    public const int ObjectCountMax = 30; // SAFARI_OBJ_MAX

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    public SafariMap4 MapID { get => (SafariMap4)Data[0]; set => Data[0] = (byte)value; }

    /// <summary>
    /// Objects in use. Entries must stay front-packed: the game reads <c>obj[0..ObjectCount)</c> only.
    /// </summary>
    public byte ObjectCount
    {
        get => Data[1];
        set => Data[1] = Math.Min(value, (byte)ObjectCountMax);
    }

    private const int OfsObjects = 2;

    public SafariObject4 GetObject(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, ObjectCountMax);
        return new(Raw.Slice(OfsObjects + (index * SafariObject4.SIZE), SafariObject4.SIZE));
    }

    /// <summary>Removes an object and compacts the remainder, matching <c>SafariLayout_DelObj</c>.</summary>
    public void RemoveObject(int index)
    {
        var count = ObjectCount;
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, count);

        var objects = Data.Slice(OfsObjects, ObjectCountMax * SafariObject4.SIZE);
        var tail = objects[((index + 1) * SafariObject4.SIZE)..(count * SafariObject4.SIZE)];
        tail.CopyTo(objects[(index * SafariObject4.SIZE)..]);
        objects.Slice((count - 1) * SafariObject4.SIZE, SafariObject4.SIZE).Clear();
        ObjectCount = (byte)(count - 1);
    }

    public void Clear()
    {
        var map = MapID;
        Data.Clear();
        MapID = map;
    }
}

/// <summary>
/// A single object placed within a Safari area.
/// </summary>
/// <remarks>size 0x4</remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class SafariObject4(Memory<byte> Raw)
{
    public const int SIZE = 4;

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    public byte ID { get => Data[0]; set => Data[0] = value; }
    public byte X  { get => Data[1]; set => Data[1] = value; }
    public byte Y  { get => Data[2]; set => Data[2] = value; }
    public byte Z  { get => Data[3]; set => Data[3] = value; }

    public override string ToString() => $"{ID:X2} @ ({X},{Y},{Z})";
}

/// <summary>
/// Identity of the trainer whose Safari layout is currently loaned to the player.
/// </summary>
/// <remarks>size 0x28</remarks>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class SafariManager4(Memory<byte> Raw)
{
    public const int SIZE = 0x28;

    public readonly Memory<byte> Raw = Raw;
    private Span<byte> Data => Raw.Span;

    /// <summary>Console RTC seconds when the data was received; expiry is measured from this.</summary>
    public long CheckTime { get => ReadInt64LittleEndian(Data); set => WriteInt64LittleEndian(Data, value); }

    /// <summary>Owner RTC offset when received. A mismatch on load invalidates the data.</summary>
    public long RTCOffset { get => ReadInt64LittleEndian(Data[0x8..]); set => WriteInt64LittleEndian(Data[0x8..], value); }

    public bool IsValid { get => Data[0x10] != 0; set => Data[0x10] = (byte)(value ? 1 : 0); }
    public byte Gender  { get => Data[0x11]; set => Data[0x11] = value; }
    public byte Region  { get => Data[0x12]; set => Data[0x12] = value; }
    public byte Version { get => Data[0x13]; set => Data[0x13] = value; }
    public uint ID32    { get => ReadUInt32LittleEndian(Data[0x14..]); set => WriteUInt32LittleEndian(Data[0x14..], value); }

    private Span<byte> NameTrash => Data.Slice(0x18, 16);

    public string Name
    {
        get => StringConverter4.GetString(NameTrash);
        set => StringConverter4.SetString(NameTrash, value, 7, Language, StringConverterOption.None);
    }

    /// <summary>No language byte is stored; callers should pass the save file's language.</summary>
    public byte Language { get; set; }

    public override string ToString() => IsValid ? $"{Name} ({ID32:X8})" : "(none)";
}

/// <summary>
/// Safari Zone area types. Names are the decomp's internal identifiers (SAFARI_ZONE_AREA_*);
/// verify the English area names against the in-game text bank before surfacing them in the UI.
/// </summary>
public enum SafariMap4 : byte
{
    Plains = 0,
    Meadow = 1,
    Savannah = 2,
    Peak = 3,
    RockyBeach = 4,
    Wetland = 5,
    Forest = 6,
    Swamp = 7,
    Marshland = 8,
    Wasteland = 9,
    Mountain = 10,
    Desert = 11,
}
