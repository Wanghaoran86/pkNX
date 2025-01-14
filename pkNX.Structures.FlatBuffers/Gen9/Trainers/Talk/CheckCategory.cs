using FlatSharp.Attributes;
// ReSharper disable UnusedMember.Global

namespace pkNX.Structures.FlatBuffers;

[FlatBufferEnum(typeof(int))]
public enum CheckCategory
{
    TurnCheck = 0,
    PokemonCheck = 1,
    FirstDamage = 2,
    HpCheck = 3,
    WazaCheck = 4,
    TurnEndCheck = 5,
    WazaAdvantageCheck = 6,
    WazaNoneCheck = 7,
    WazaCriticalCheck = 8,
    WeatherCheck = 9,
    StartCheck = 10,
    SelectActionCheck = 11,
    PokemonIDCheck = 12,
    UseItem = 13,
    ChengeGem = 14,
    turnEndAndGemStartCheck = 15,
    turnEndAndPokemonDownCheck = 16,
    turnEndAndHpCheck = 17,
    turnEndAndWazaAdvantageCheck = 18,
    turnEndAndTurnCount = 19,
    WazaDisadvantageCheck = 20,
    WazaAdvantageAttackCheck = 21,
}
