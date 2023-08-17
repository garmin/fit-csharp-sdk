#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.120Release
// Tag = production/release/21.120.00-0-g2d77811
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile GarminProduct type as a class
    /// </summary>
    public static class GarminProduct 
    {
        public const ushort Hrm1 = 1;
        public const ushort Axh01 = 2; // AXH01 HRM chipset
        public const ushort Axb01 = 3;
        public const ushort Axb02 = 4;
        public const ushort Hrm2ss = 5;
        public const ushort DsiAlf02 = 6;
        public const ushort Hrm3ss = 7;
        public const ushort HrmRunSingleByteProductId = 8; // hrm_run model for HRM ANT+ messaging
        public const ushort Bsm = 9; // BSM model for ANT+ messaging
        public const ushort Bcm = 10; // BCM model for ANT+ messaging
        public const ushort Axs01 = 11; // AXS01 HRM Bike Chipset model for ANT+ messaging
        public const ushort HrmTriSingleByteProductId = 12; // hrm_tri model for HRM ANT+ messaging
        public const ushort Hrm4RunSingleByteProductId = 13; // hrm4 run model for HRM ANT+ messaging
        public const ushort Fr225SingleByteProductId = 14; // fr225 model for HRM ANT+ messaging
        public const ushort Gen3BsmSingleByteProductId = 15; // gen3_bsm model for Bike Speed ANT+ messaging
        public const ushort Gen3BcmSingleByteProductId = 16; // gen3_bcm model for Bike Cadence ANT+ messaging
        public const ushort OHR = 255; // Garmin Wearable Optical Heart Rate Sensor for ANT+ HR Profile Broadcasting
        public const ushort Fr301China = 473;
        public const ushort Fr301Japan = 474;
        public const ushort Fr301Korea = 475;
        public const ushort Fr301Taiwan = 494;
        public const ushort Fr405 = 717; // Forerunner 405
        public const ushort Fr50 = 782; // Forerunner 50
        public const ushort Fr405Japan = 987;
        public const ushort Fr60 = 988; // Forerunner 60
        public const ushort DsiAlf01 = 1011;
        public const ushort Fr310xt = 1018; // Forerunner 310
        public const ushort Edge500 = 1036;
        public const ushort Fr110 = 1124; // Forerunner 110
        public const ushort Edge800 = 1169;
        public const ushort Edge500Taiwan = 1199;
        public const ushort Edge500Japan = 1213;
        public const ushort Chirp = 1253;
        public const ushort Fr110Japan = 1274;
        public const ushort Edge200 = 1325;
        public const ushort Fr910xt = 1328;
        public const ushort Edge800Taiwan = 1333;
        public const ushort Edge800Japan = 1334;
        public const ushort Alf04 = 1341;
        public const ushort Fr610 = 1345;
        public const ushort Fr210Japan = 1360;
        public const ushort VectorSs = 1380;
        public const ushort VectorCp = 1381;
        public const ushort Edge800China = 1386;
        public const ushort Edge500China = 1387;
        public const ushort ApproachG10 = 1405;
        public const ushort Fr610Japan = 1410;
        public const ushort Edge500Korea = 1422;
        public const ushort Fr70 = 1436;
        public const ushort Fr310xt4t = 1446;
        public const ushort Amx = 1461;
        public const ushort Fr10 = 1482;
        public const ushort Edge800Korea = 1497;
        public const ushort Swim = 1499;
        public const ushort Fr910xtChina = 1537;
        public const ushort Fenix = 1551;
        public const ushort Edge200Taiwan = 1555;
        public const ushort Edge510 = 1561;
        public const ushort Edge810 = 1567;
        public const ushort Tempe = 1570;
        public const ushort Fr910xtJapan = 1600;
        public const ushort Fr620 = 1623;
        public const ushort Fr220 = 1632;
        public const ushort Fr910xtKorea = 1664;
        public const ushort Fr10Japan = 1688;
        public const ushort Edge810Japan = 1721;
        public const ushort VirbElite = 1735;
        public const ushort EdgeTouring = 1736; // Also Edge Touring Plus
        public const ushort Edge510Japan = 1742;
        public const ushort HrmTri = 1743; // Also HRM-Swim
        public const ushort HrmRun = 1752;
        public const ushort Fr920xt = 1765;
        public const ushort Edge510Asia = 1821;
        public const ushort Edge810China = 1822;
        public const ushort Edge810Taiwan = 1823;
        public const ushort Edge1000 = 1836;
        public const ushort VivoFit = 1837;
        public const ushort VirbRemote = 1853;
        public const ushort VivoKi = 1885;
        public const ushort Fr15 = 1903;
        public const ushort VivoActive = 1907;
        public const ushort Edge510Korea = 1918;
        public const ushort Fr620Japan = 1928;
        public const ushort Fr620China = 1929;
        public const ushort Fr220Japan = 1930;
        public const ushort Fr220China = 1931;
        public const ushort ApproachS6 = 1936;
        public const ushort VivoSmart = 1956;
        public const ushort Fenix2 = 1967;
        public const ushort Epix = 1988;
        public const ushort Fenix3 = 2050;
        public const ushort Edge1000Taiwan = 2052;
        public const ushort Edge1000Japan = 2053;
        public const ushort Fr15Japan = 2061;
        public const ushort Edge520 = 2067;
        public const ushort Edge1000China = 2070;
        public const ushort Fr620Russia = 2072;
        public const ushort Fr220Russia = 2073;
        public const ushort VectorS = 2079;
        public const ushort Edge1000Korea = 2100;
        public const ushort Fr920xtTaiwan = 2130;
        public const ushort Fr920xtChina = 2131;
        public const ushort Fr920xtJapan = 2132;
        public const ushort Virbx = 2134;
        public const ushort VivoSmartApac = 2135;
        public const ushort EtrexTouch = 2140;
        public const ushort Edge25 = 2147;
        public const ushort Fr25 = 2148;
        public const ushort VivoFit2 = 2150;
        public const ushort Fr225 = 2153;
        public const ushort Fr630 = 2156;
        public const ushort Fr230 = 2157;
        public const ushort Fr735xt = 2158;
        public const ushort VivoActiveApac = 2160;
        public const ushort Vector2 = 2161;
        public const ushort Vector2s = 2162;
        public const ushort Virbxe = 2172;
        public const ushort Fr620Taiwan = 2173;
        public const ushort Fr220Taiwan = 2174;
        public const ushort Truswing = 2175;
        public const ushort D2airvenu = 2187;
        public const ushort Fenix3China = 2188;
        public const ushort Fenix3Twn = 2189;
        public const ushort VariaHeadlight = 2192;
        public const ushort VariaTaillightOld = 2193;
        public const ushort EdgeExplore1000 = 2204;
        public const ushort Fr225Asia = 2219;
        public const ushort VariaRadarTaillight = 2225;
        public const ushort VariaRadarDisplay = 2226;
        public const ushort Edge20 = 2238;
        public const ushort Edge520Asia = 2260;
        public const ushort Edge520Japan = 2261;
        public const ushort D2Bravo = 2262;
        public const ushort ApproachS20 = 2266;
        public const ushort VivoSmart2 = 2271;
        public const ushort Edge1000Thai = 2274;
        public const ushort VariaRemote = 2276;
        public const ushort Edge25Asia = 2288;
        public const ushort Edge25Jpn = 2289;
        public const ushort Edge20Asia = 2290;
        public const ushort ApproachX40 = 2292;
        public const ushort Fenix3Japan = 2293;
        public const ushort VivoSmartEmea = 2294;
        public const ushort Fr630Asia = 2310;
        public const ushort Fr630Jpn = 2311;
        public const ushort Fr230Jpn = 2313;
        public const ushort Hrm4Run = 2327;
        public const ushort EpixJapan = 2332;
        public const ushort VivoActiveHr = 2337;
        public const ushort VivoSmartGpsHr = 2347;
        public const ushort VivoSmartHr = 2348;
        public const ushort VivoSmartHrAsia = 2361;
        public const ushort VivoSmartGpsHrAsia = 2362;
        public const ushort VivoMove = 2368;
        public const ushort VariaTaillight = 2379;
        public const ushort Fr235Asia = 2396;
        public const ushort Fr235Japan = 2397;
        public const ushort VariaVision = 2398;
        public const ushort VivoFit3 = 2406;
        public const ushort Fenix3Korea = 2407;
        public const ushort Fenix3Sea = 2408;
        public const ushort Fenix3Hr = 2413;
        public const ushort VirbUltra30 = 2417;
        public const ushort IndexSmartScale = 2429;
        public const ushort Fr235 = 2431;
        public const ushort Fenix3Chronos = 2432;
        public const ushort Oregon7xx = 2441;
        public const ushort Rino7xx = 2444;
        public const ushort EpixKorea = 2457;
        public const ushort Fenix3HrChn = 2473;
        public const ushort Fenix3HrTwn = 2474;
        public const ushort Fenix3HrJpn = 2475;
        public const ushort Fenix3HrSea = 2476;
        public const ushort Fenix3HrKor = 2477;
        public const ushort Nautix = 2496;
        public const ushort VivoActiveHrApac = 2497;
        public const ushort Fr35 = 2503;
        public const ushort Oregon7xxWw = 2512;
        public const ushort Edge820 = 2530;
        public const ushort EdgeExplore820 = 2531;
        public const ushort Fr735xtApac = 2533;
        public const ushort Fr735xtJapan = 2534;
        public const ushort Fenix5s = 2544;
        public const ushort D2BravoTitanium = 2547;
        public const ushort VariaUt800 = 2567; // Varia UT 800 SW
        public const ushort RunningDynamicsPod = 2593;
        public const ushort Edge820China = 2599;
        public const ushort Edge820Japan = 2600;
        public const ushort Fenix5x = 2604;
        public const ushort VivoFitJr = 2606;
        public const ushort VivoSmart3 = 2622;
        public const ushort VivoSport = 2623;
        public const ushort Edge820Taiwan = 2628;
        public const ushort Edge820Korea = 2629;
        public const ushort Edge820Sea = 2630;
        public const ushort Fr35Hebrew = 2650;
        public const ushort ApproachS60 = 2656;
        public const ushort Fr35Apac = 2667;
        public const ushort Fr35Japan = 2668;
        public const ushort Fenix3ChronosAsia = 2675;
        public const ushort Virb360 = 2687;
        public const ushort Fr935 = 2691;
        public const ushort Fenix5 = 2697;
        public const ushort Vivoactive3 = 2700;
        public const ushort Fr235ChinaNfc = 2733;
        public const ushort Foretrex601_701 = 2769;
        public const ushort VivoMoveHr = 2772;
        public const ushort Edge1030 = 2713;
        public const ushort Fr35Sea = 2727;
        public const ushort Vector3 = 2787;
        public const ushort Fenix5Asia = 2796;
        public const ushort Fenix5sAsia = 2797;
        public const ushort Fenix5xAsia = 2798;
        public const ushort ApproachZ80 = 2806;
        public const ushort Fr35Korea = 2814;
        public const ushort D2charlie = 2819;
        public const ushort VivoSmart3Apac = 2831;
        public const ushort VivoSportApac = 2832;
        public const ushort Fr935Asia = 2833;
        public const ushort Descent = 2859;
        public const ushort VivoFit4 = 2878;
        public const ushort Fr645 = 2886;
        public const ushort Fr645m = 2888;
        public const ushort Fr30 = 2891;
        public const ushort Fenix5sPlus = 2900;
        public const ushort Edge130 = 2909;
        public const ushort Edge1030Asia = 2924;
        public const ushort Vivosmart4 = 2927;
        public const ushort VivoMoveHrAsia = 2945;
        public const ushort ApproachX10 = 2962;
        public const ushort Fr30Asia = 2977;
        public const ushort Vivoactive3mW = 2988;
        public const ushort Fr645Asia = 3003;
        public const ushort Fr645mAsia = 3004;
        public const ushort EdgeExplore = 3011;
        public const ushort Gpsmap66 = 3028;
        public const ushort ApproachS10 = 3049;
        public const ushort Vivoactive3mL = 3066;
        public const ushort ApproachG80 = 3085;
        public const ushort Edge130Asia = 3092;
        public const ushort Edge1030Bontrager = 3095;
        public const ushort Fenix5Plus = 3110;
        public const ushort Fenix5xPlus = 3111;
        public const ushort Edge520Plus = 3112;
        public const ushort Fr945 = 3113;
        public const ushort Edge530 = 3121;
        public const ushort Edge830 = 3122;
        public const ushort InstinctEsports = 3126;
        public const ushort Fenix5sPlusApac = 3134;
        public const ushort Fenix5xPlusApac = 3135;
        public const ushort Edge520PlusApac = 3142;
        public const ushort DescentT1 = 3143;
        public const ushort Fr235lAsia = 3144;
        public const ushort Fr245Asia = 3145;
        public const ushort VivoActive3mApac = 3163;
        public const ushort Gen3Bsm = 3192; // gen3 bike speed sensor
        public const ushort Gen3Bcm = 3193; // gen3 bike cadence sensor
        public const ushort VivoSmart4Asia = 3218;
        public const ushort Vivoactive4Small = 3224;
        public const ushort Vivoactive4Large = 3225;
        public const ushort Venu = 3226;
        public const ushort MarqDriver = 3246;
        public const ushort MarqAviator = 3247;
        public const ushort MarqCaptain = 3248;
        public const ushort MarqCommander = 3249;
        public const ushort MarqExpedition = 3250;
        public const ushort MarqAthlete = 3251;
        public const ushort DescentMk2 = 3258;
        public const ushort Gpsmap66i = 3284;
        public const ushort Fenix6SSport = 3287;
        public const ushort Fenix6S = 3288;
        public const ushort Fenix6Sport = 3289;
        public const ushort Fenix6 = 3290;
        public const ushort Fenix6x = 3291;
        public const ushort HrmDual = 3299; // HRM-Dual
        public const ushort HrmPro = 3300; // HRM-Pro
        public const ushort VivoMove3Premium = 3308;
        public const ushort ApproachS40 = 3314;
        public const ushort Fr245mAsia = 3321;
        public const ushort Edge530Apac = 3349;
        public const ushort Edge830Apac = 3350;
        public const ushort VivoMove3 = 3378;
        public const ushort VivoActive4SmallAsia = 3387;
        public const ushort VivoActive4LargeAsia = 3388;
        public const ushort VivoActive4OledAsia = 3389;
        public const ushort Swim2 = 3405;
        public const ushort MarqDriverAsia = 3420;
        public const ushort MarqAviatorAsia = 3421;
        public const ushort VivoMove3Asia = 3422;
        public const ushort Fr945Asia = 3441;
        public const ushort VivoActive3tChn = 3446;
        public const ushort MarqCaptainAsia = 3448;
        public const ushort MarqCommanderAsia = 3449;
        public const ushort MarqExpeditionAsia = 3450;
        public const ushort MarqAthleteAsia = 3451;
        public const ushort InstinctSolar = 3466;
        public const ushort Fr45Asia = 3469;
        public const ushort Vivoactive3Daimler = 3473;
        public const ushort LegacyRey = 3498;
        public const ushort LegacyDarthVader = 3499;
        public const ushort LegacyCaptainMarvel = 3500;
        public const ushort LegacyFirstAvenger = 3501;
        public const ushort Fenix6sSportAsia = 3512;
        public const ushort Fenix6sAsia = 3513;
        public const ushort Fenix6SportAsia = 3514;
        public const ushort Fenix6Asia = 3515;
        public const ushort Fenix6xAsia = 3516;
        public const ushort LegacyCaptainMarvelAsia = 3535;
        public const ushort LegacyFirstAvengerAsia = 3536;
        public const ushort LegacyReyAsia = 3537;
        public const ushort LegacyDarthVaderAsia = 3538;
        public const ushort DescentMk2s = 3542;
        public const ushort Edge130Plus = 3558;
        public const ushort Edge1030Plus = 3570;
        public const ushort Rally200 = 3578; // Rally 100/200 Power Meter Series
        public const ushort Fr745 = 3589;
        public const ushort Venusq = 3600;
        public const ushort Lily = 3615;
        public const ushort MarqAdventurer = 3624;
        public const ushort Enduro = 3638;
        public const ushort Swim2Apac = 3639;
        public const ushort MarqAdventurerAsia = 3648;
        public const ushort Fr945Lte = 3652;
        public const ushort DescentMk2Asia = 3702; // Mk2 and Mk2i
        public const ushort Venu2 = 3703;
        public const ushort Venu2s = 3704;
        public const ushort VenuDaimlerAsia = 3737;
        public const ushort MarqGolfer = 3739;
        public const ushort VenuDaimler = 3740;
        public const ushort Fr745Asia = 3794;
        public const ushort LilyAsia = 3809;
        public const ushort Edge1030PlusAsia = 3812;
        public const ushort Edge130PlusAsia = 3813;
        public const ushort ApproachS12 = 3823;
        public const ushort EnduroAsia = 3872;
        public const ushort VenusqAsia = 3837;
        public const ushort Edge1040 = 3843;
        public const ushort MarqGolferAsia = 3850;
        public const ushort Venu2Plus = 3851;
        public const ushort Gnss = 3865;
        public const ushort Fr55 = 3869;
        public const ushort Instinct2 = 3888;
        public const ushort Fenix7s = 3905;
        public const ushort Fenix7 = 3906;
        public const ushort Fenix7x = 3907;
        public const ushort Fenix7sApac = 3908;
        public const ushort Fenix7Apac = 3909;
        public const ushort Fenix7xApac = 3910;
        public const ushort ApproachG12 =  3927;
        public const ushort DescentMk2sAsia = 3930;
        public const ushort ApproachS42 = 3934;
        public const ushort EpixGen2 = 3943;
        public const ushort EpixGen2Apac = 3944;
        public const ushort Venu2sAsia = 3949;
        public const ushort Venu2Asia = 3950;
        public const ushort Fr945LteAsia = 3978;
        public const ushort VivoMoveSport = 3982;
        public const ushort VivomoveTrend = 3983;
        public const ushort ApproachS12Asia = 3986;
        public const ushort Fr255Music = 3990;
        public const ushort Fr255SmallMusic = 3991;
        public const ushort Fr255 = 3992;
        public const ushort Fr255Small = 3993;
        public const ushort ApproachG12Asia =  4001;
        public const ushort ApproachS42Asia = 4002;
        public const ushort DescentG1 = 4005;
        public const ushort Venu2PlusAsia = 4017;
        public const ushort Fr955 = 4024;
        public const ushort Fr55Asia = 4033;
        public const ushort Edge540 = 4061;
        public const ushort Edge840 = 4062;
        public const ushort Vivosmart5 = 4063;
        public const ushort Instinct2Asia = 4071;
        public const ushort MarqGen2 = 4105; // Adventurer, Athlete, Captain, Golfer
        public const ushort Venusq2 = 4115;
        public const ushort Venusq2music = 4116;
        public const ushort MarqGen2Aviator = 4124;
        public const ushort D2AirX10 = 4125;
        public const ushort HrmProPlus = 4130;
        public const ushort DescentG1Asia = 4132;
        public const ushort Tactix7 = 4135;
        public const ushort InstinctCrossover = 4155;
        public const ushort EdgeExplore2 = 4169;
        public const ushort ApproachS70 = 4233;
        public const ushort Fr265Large = 4257;
        public const ushort Fr265Small = 4258;
        public const ushort TacxNeoSmart = 4265; // Neo Smart, Tacx
        public const ushort TacxNeo2Smart = 4266; // Neo 2 Smart, Tacx
        public const ushort TacxNeo2TSmart = 4267; // Neo 2T Smart, Tacx
        public const ushort TacxNeoSmartBike = 4268; // Neo Smart Bike, Tacx
        public const ushort TacxSatoriSmart = 4269; // Satori Smart, Tacx
        public const ushort TacxFlowSmart = 4270; // Flow Smart, Tacx
        public const ushort TacxVortexSmart = 4271; // Vortex Smart, Tacx
        public const ushort TacxBushidoSmart = 4272; // Bushido Smart, Tacx
        public const ushort TacxGeniusSmart = 4273; // Genius Smart, Tacx
        public const ushort TacxFluxFluxSSmart = 4274; // Flux/Flux S Smart, Tacx
        public const ushort TacxFlux2Smart = 4275; // Flux 2 Smart, Tacx
        public const ushort TacxMagnum = 4276; // Magnum, Tacx
        public const ushort Edge1040Asia = 4305;
        public const ushort EpixGen2Pro42 = 4312;
        public const ushort EpixGen2Pro47 = 4313;
        public const ushort EpixGen2Pro51 = 4314;
        public const ushort Fr965 = 4315;
        public const ushort Enduro2 = 4341;
        public const ushort Fenix7sProSolar = 4374;
        public const ushort Fenix7ProSolar = 4375;
        public const ushort Fenix7xProSolar = 4376;
        public const ushort Instinct2x = 4394;
        public const ushort DescentT2 = 4442;
        public const ushort Sdm4 = 10007; // SDM4 footpod
        public const ushort EdgeRemote = 10014;
        public const ushort TacxTrainingAppWin = 20533;
        public const ushort TacxTrainingAppMac = 20534;
        public const ushort TacxTrainingAppMacCatalyst = 20565;
        public const ushort TrainingCenter = 20119;
        public const ushort TacxTrainingAppAndroid = 30045;
        public const ushort TacxTrainingAppIos = 30046;
        public const ushort TacxTrainingAppLegacy = 30047;
        public const ushort ConnectiqSimulator = 65531;
        public const ushort AndroidAntplusPlugin = 65532;
        public const ushort Connect = 65534; // Garmin Connect website
        public const ushort Invalid = (ushort)0xFFFF;


    }
}

