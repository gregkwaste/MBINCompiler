﻿namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        public bool Unknown0;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;

        public GcSpaceshipTravelData Unknown4;
        public GcSpaceshipTravelData Unknown4C;
        public GcSpaceshipTravelData Unknown94;

        public float UnknownDC;
        public float UnknownE0;

        public GcShipAIAttackData UnknownE4;

        public int UnknownInt17C;
        public int UnknownInt180;
        public int UnknownInt184;
        public float Unknown188;
        public float Unknown18C;
        public float Unknown190;
        public float Unknown194;
        public float Unknown198;

        public GcSpaceshipTravelData Unknown19C;

        public float Unknown1E4;
        public float Unknown1E8;
        public float Unknown1EC;
        public float Unknown1F0;
        public float Unknown1F4;
        public float Unknown1F8;
        public float Unknown1FC;
        public float Unknown200;
        public float Unknown204;
        public float Unknown208;
        public float Unknown20C;
        public float Unknown210;
        public float Unknown214;
        public float Unknown218;
        public float Unknown21C;
        public float Unknown220;
        public float Unknown224;
        public float Unknown228;
        public float Unknown22C;
        public float Unknown230;
        public float Unknown234;
        public float Unknown238;
        public float Unknown23C;
        public float Unknown240;
        public float Unknown244;
        public float Unknown248;
        public float Unknown24C;
        public float Unknown250;
        public float Unknown254;
        public float Unknown258;
        public float Unknown25C;
        public float Unknown260;
        public float Unknown264;        // this is actually a QWORD... Only looks like it has 0x4 data anyway... maybe it is a long or something?
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding268;       // [rdi+26Ch], esi

        public float Unknown270;
        public float Unknown274;
        public float Unknown278;
        public float Unknown27C;
        public float Unknown280;
        public float Unknown284;
        public float Unknown288;
        public float Unknown28C;
        public float Unknown290;
        public float Unknown294;
        public float Unknown298;
        public float Unknown29C;
        public float Unknown2A0;
        public float Unknown2A4;
        public float Unknown2A8;
        public float Unknown2AC;
        public int Unknown2B0;
        public float Unknown2B4;
        public float Unknown2B8;
        public float Unknown2BC;
        public float Unknown2C0;
        public bool Unknown2C4;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding2C5;
        public float Unknown2C8;

        [NMS(Size = 0x80)]
        /* 0x2CC */ public string HangarScene;

        public float Unknown34C;
        public float Unknown350;
        public float Unknown354;
        public float Unknown358;
        public float Unknown35C;
        public float Unknown360;
        public float Unknown364;
        public float Unknown368;
        public float Unknown36C;
        public float Unknown370;
        public float Unknown374;
        public float Unknown378;
        public float Unknown37C;
        public float Unknown380;        // QWORD
        public float Unknown384;        // probably unused
        public float Unknown388;        // [rdi+388h], esi
        public float Unknown38C;

        public TkHitCurveData Unknown390;

        public float Unknown3A0;
        public float Unknown3A4;        // QWORD
        public float Unknown3A8;        // probably unused
        public float Unknown3AC;
        public float Unknown3B0;
        public float Unknown3B4;
        public float Unknown3B8;
        public float Unknown3BC;        // QWORD
        public float Unknown3C0;        // probably unused
        public float Unknown3C4;        // QWORD
        public float Unknown3C8;        // probably unused
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding3CC;       // I guess?? maybe padding at the end of a struct?
        public float Unknown3D0;        // [rdi+3D0h], sil
        public float Unknown3D4;
        public float Unknown3D8;
        public float Unknown3DC;
        public float Unknown3E0;
        public float Unknown3E4;
        public float Unknown3E8;
        public float Unknown3EC;
        public float Unknown3F0;
        public float Unknown3F4;
        public float Unknown3F8;
        public float Unknown3FC;
        public float Unknown400;
        public float Unknown404;
        public float Unknown408;
        public float Unknown40C;
        public float Unknown410;
        public float Unknown414;
        public float Unknown418;
        public float Unknown41C;
        public float Unknown420;
        public float Unknown424;
        public float Unknown428;
        public float Unknown42C;
        public float Unknown430;
        public float Unknown434;
        public float Unknown438;
        public float Unknown43C;
        public float Unknown440;
        public float Unknown444;
        public float Unknown448;
        public float Unknown44C;
        public float Unknown450;
        public float Unknown454;
        public int UnknownInt458;
        public int UnknownInt45C;
        public int UnknownInt460;
        public int UnknownInt464;

        [NMS(Size = 0x10)]
        public string Unknown468;
        [NMS(Size = 0x10)]
        public string Unknown478;
        [NMS(Size = 0x10)]
        public string Unknown488;

        public int UnknownInt498;
        public int UnknownInt49C;
        public int UnknownInt4A0;
        public int UnknownInt4A4;
        public int UnknownInt4A8;
        public int UnknownInt4AC;
        public float Unknown4B0;
        public float Unknown4B4;

        public GcShipAIAttackData Unknown4B8;

        public float Unknown550;
        public float Unknown554;
        public float Unknown558;
        public float Unknown55C;
        public float Unknown560;
        public float Unknown564;
        public float Unknown568;
        public float Unknown56C;
        public int UnknownInt570;
        public int UnknownInt574;
        public float Unknown578;
        public float Unknown57C;
        public float Unknown580;
        public float Unknown584;
        public float Unknown588;
        public float Unknown58C;
        public float Unknown590;
        public float Unknown594;
        public float Unknown598;
        public float Unknown59C;
        public float Unknown5A0;
        public float Unknown5A4;
        public float Unknown5A8;
        public bool Unknown5AC;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5AD;
        public float Unknown5B0;
        public float Unknown5B4;
        public float Unknown5B8;
        public bool Unknown5BC;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5BD;
        public int UnknownInt5C0;
        public float Unknown5C4;
        public float Unknown5C8;
        public float Unknown5CC;
        public float Unknown5D0;
        public float Unknown5D4;
        public float Unknown5D8;
        public float Unknown5DC;
        public float Unknown5E0;
        public float Unknown5E4;
        public float Unknown5E8;
        public float Unknown5EC;
        public float Unknown5F0;
        public float Unknown5F4;        // QWORD
        public int UnknownInt5F8;        // probably unused
        public float Unknown5FC;
        public float Unknown600;

        [NMS(Size = 0x100)]
        public string Unknown604;

        public float Unknown704;
        public float Unknown708;
        public float Unknown70C;
        public float Unknown710;
        public float Unknown714;
        public float Unknown718;
        public float Unknown71C;
        public float Unknown720;
        public int UnknownInt724;
        public float Unknown728;
        public float Unknown72C;
        public int UnknownInt730;
        public float Unknown734;
        public float Unknown738;
        public float Unknown73C;
        public float Unknown740;
        public float Unknown744;
        public float Unknown748;
        public float Unknown74C;
        public float Unknown750;
        public float Unknown754;
        public float Unknown758;
        public float Unknown75C;
        public float Unknown760;
        public float Unknown764;
        public float Unknown768;
        public float Unknown76C;
        public float Unknown770;
        public float Unknown774;
        public float Unknown778;
        public float Unknown77C;
        public float Unknown780;
        public float Unknown784;
        public float Unknown788;
        public float Unknown78C;
        public bool Unknown790;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding791;
        public float Unknown794;
        public float Unknown798;
        public int UnknownInt79C;
        public float Unknown7A0;
        public float Unknown7A4;
        public float Unknown7A8;
        public float Unknown7AC;
        public float Unknown7B0;
        public float Unknown7B4;
        public float Unknown7B8;
        public float Unknown7BC;
        public float Unknown7C0;
        public float Unknown7C4;        // QWORD
        public float Unknown7C8;        // probably not needed...
        public float Unknown7CC;        // [rdi+7CCh], esi
        public float Unknown7D0;
        public float Unknown7D4;
        public float Unknown7D8;
        public float Unknown7DC;        // [rdi+7DCh], sil
        public int UnknownInt7E0;
        public int UnknownInt7E4;
        public float Unknown7E8;
        public float Unknown7EC;
        public float Unknown7F0;
        public float Unknown7F4;
        public float Unknown7F8;
        public float Unknown7FC;
        public float Unknown800;
        public float Unknown804;
        public float Unknown808;
        public float Unknown80C;
        public float Unknown810;
        public float Unknown814;
        public float Unknown818;
        public float Unknown81C;
        public float Unknown820;
        public float Unknown824;
        public float Unknown828;
        public float Unknown82C;
        public int UnknownInt830;
        public float Unknown834;
        public float Unknown838;
        public float Unknown83C;
        public float Unknown840;
        public float Unknown844;
        public float Unknown848;
        public float Unknown84C;
        public float Unknown850;
        public float Unknown854;
        public float Unknown858;
        public float Unknown85C;
        public float Unknown860;
        public float Unknown864;
        public float Unknown868;
        public float Unknown86C;
        public float Unknown870;
        public float Unknown874;
        public float Unknown878;
        public float Unknown87C;
        public float Unknown880;
        public float Unknown884;
        public float Unknown888;
        public float Unknown88C;
        public float Unknown890;
        public float Unknown894;
        public float Unknown898;        // QWORD
        public int UnknownInt89C;        // probably not needed
        public float Unknown8A0;
        public float Unknown8A4;
        public float Unknown8A8;
        public float Unknown8AC;
        public float Unknown8B0;
        public float Unknown8B4;
        public float Unknown8B8;
        public float Unknown8BC;
        public float Unknown8C0;

        public GcProjectileLineData Unknown8C4;

        public GcSpaceshipTravelData Unknown8EC;

        public float Unknown934;
        public float Unknown938;
        public float Unknown93C;
        public float Unknown940;
        public float Unknown944;
        public float Unknown948;
        public float Unknown94C;
        public float Unknown950;
        public float Unknown954;
        public float Unknown958;
        public float Unknown95C;
        public float Unknown960;
        public float Unknown964;        // QWORD
        public float Unknown968;        // probably not needed
        public float Unknown96C;
        public float Unknown970;
        public float Unknown974;
        public float Unknown978;
        public float Unknown97C;
        public float Unknown980;
        public float Unknown984;
        public float Unknown988;
        public float Unknown98C;
        public float Unknown990;
        public float Unknown994;
        public float Unknown998;
        public float Unknown99C;
        public float Unknown9A0;
        public float Unknown9A4;
        public float Unknown9A8;
        public float Unknown9AC;
        public float Unknown9B0;
        public float Unknown9B4;
        public float Unknown9B8;
        public float Unknown9BC;
        public float Unknown9C0;
        public float Unknown9C4;
        public float Unknown9C8;
        public float Unknown9CC;
        public float Unknown9D0;
        public float Unknown9D4;
        public float Unknown9D8;
        public float Unknown9DC;
        public float Unknown9E0;
        public float Unknown9E4;
        public float Unknown9E8;
        public float Unknown9EC;

        public GcShipAIDeathData Unknown9F0;

        public GcShipAIAttackData UnknownA0C;
        public GcShipAIAttackData UnknownAA4;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingB3C;
        public GcShipAIPlanetPatrolData UnknownB40;

    }
}
