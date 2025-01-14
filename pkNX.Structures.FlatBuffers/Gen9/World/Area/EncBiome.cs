using FlatSharp.Attributes;
// ReSharper disable UnusedMember.Global

namespace pkNX.Structures.FlatBuffers;

[FlatBufferEnum(typeof(byte))]
public enum EncBiome : byte
{
    None = 0,
    Prairie = 1,
    Forest = 2,
    Town = 3,
    Desert = 4,
    Mountain = 5,
    Snowfield = 6,
    Swamp = 7,
    Lake = 8,
    Riverside = 9,
    Ocean = 10,
    Underground = 11,
    Rocky_area = 12,
    Cave = 13,
    Beach = 14,
    Flower = 15,
    BambooForest = 16,
    Wasteland = 17,
    Volcano = 18,
    Mine = 19,
    Olive = 20,
    Ruins = 21,
    CaveWater = 22,
}
