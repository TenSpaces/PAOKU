// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3
    {
        [TestCompiler]
        public static void uint3_zero()
        {
            TestUtils.AreEqual(uint3.zero.x, 0u);
            TestUtils.AreEqual(uint3.zero.y, 0u);
            TestUtils.AreEqual(uint3.zero.z, 0u);
        }

        [TestCompiler]
        public static void uint3_constructor()
        {
            uint3 a = new uint3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void uint3_scalar_constructor()
        {
            uint3 a = new uint3(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
            TestUtils.AreEqual(a.z, 17u);
        }

        [TestCompiler]
        public static void uint3_static_constructor()
        {
            uint3 a = uint3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void uint3_static_scalar_constructor()
        {
            uint3 a = uint3(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
            TestUtils.AreEqual(a.z, 17u);
        }

        [TestCompiler]
        public static void uint3_operator_equal_wide_wide()
        {
            uint3 a0 = uint3(790229414, 970783976, 1428432738);
            uint3 b0 = uint3(612337669, 1214209108, 2120643427);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3 a1 = uint3(1578747135, 1733797753, 2001507228);
            uint3 b1 = uint3(295461214, 1510890331, 1893316566);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3 a2 = uint3(1446876437, 1777406370, 1426387268);
            uint3 b2 = uint3(921816149, 1834958575, 1482011863);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3 a3 = uint3(1809275021, 1843770816, 1172185222);
            uint3 b3 = uint3(2062852792, 226398742, 770290735);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_equal_wide_scalar()
        {
            uint3 a0 = uint3(1211464300, 1921862607, 508076684);
            uint b0 = (746972502);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3 a1 = uint3(1249127920, 746862310, 1733655277);
            uint b1 = (1394594555);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3 a2 = uint3(1884008277, 795585660, 936027116);
            uint b2 = (1682018538);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3 a3 = uint3(927605411, 1465584610, 585324157);
            uint b3 = (672785749);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_equal_scalar_wide()
        {
            uint a0 = (1150044438);
            uint3 b0 = uint3(233855098, 924242519, 1402948791);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (601381975);
            uint3 b1 = uint3(2120518068, 629187703, 1971977031);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (47183124);
            uint3 b2 = uint3(1061805787, 1009011238, 312511148);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1460673064);
            uint3 b3 = uint3(737210539, 1737844479, 1892405453);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_not_equal_wide_wide()
        {
            uint3 a0 = uint3(1660932106, 982847023, 97046264);
            uint3 b0 = uint3(107139049, 75478496, 2055495054);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3 a1 = uint3(1739517447, 1253499180, 1830584069);
            uint3 b1 = uint3(358586687, 942338347, 111564990);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3 a2 = uint3(1841470429, 1397841646, 1770890135);
            uint3 b2 = uint3(113811950, 948912488, 1080084121);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3 a3 = uint3(1906548631, 169082967, 2099271786);
            uint3 b3 = uint3(1400504872, 1032134499, 1061123400);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_not_equal_wide_scalar()
        {
            uint3 a0 = uint3(747758183, 1033001286, 1439973882);
            uint b0 = (248693828);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3 a1 = uint3(2138928797, 1432672459, 950170763);
            uint b1 = (1197845089);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3 a2 = uint3(238704450, 727205263, 1640688041);
            uint b2 = (2105962247);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3 a3 = uint3(276313906, 791998981, 2035077187);
            uint b3 = (2126300423);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_not_equal_scalar_wide()
        {
            uint a0 = (2076921066);
            uint3 b0 = uint3(2037494727, 1989050616, 48833929);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1897435904);
            uint3 b1 = uint3(514354517, 1783749164, 364694471);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (754315072);
            uint3 b2 = uint3(124108032, 1512967900, 1178825850);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1854793298);
            uint3 b3 = uint3(50286949, 2100802631, 1640811853);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_wide_wide()
        {
            uint3 a0 = uint3(1182186063, 415538999, 1667335818);
            uint3 b0 = uint3(524633529, 1032195686, 760723389);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3 a1 = uint3(1566618442, 1166180837, 639095188);
            uint3 b1 = uint3(1505751409, 431962172, 1287906509);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3 a2 = uint3(1080836365, 771119973, 928263233);
            uint3 b2 = uint3(1560084663, 1450178202, 2066166337);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3 a3 = uint3(789225474, 665243110, 1003542034);
            uint3 b3 = uint3(1107069023, 1640077524, 2103263105);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_wide_scalar()
        {
            uint3 a0 = uint3(608447185, 818840405, 869219329);
            uint b0 = (1491216667);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3 a1 = uint3(2080125385, 1361741203, 1667165786);
            uint b1 = (1214500548);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3 a2 = uint3(1615392341, 469591900, 1247103789);
            uint b2 = (840091491);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3 a3 = uint3(315321650, 1100560246, 933855388);
            uint b3 = (930950514);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_scalar_wide()
        {
            uint a0 = (548436837);
            uint3 b0 = uint3(282703327, 14370648, 1862117300);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1304793311);
            uint3 b1 = uint3(826073259, 988910157, 445132446);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1139670255);
            uint3 b2 = uint3(111349251, 1102440676, 112183144);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (1594415311);
            uint3 b3 = uint3(1890019295, 2098715503, 608933527);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_wide_wide()
        {
            uint3 a0 = uint3(592884447, 2133928932, 918957182);
            uint3 b0 = uint3(138737040, 192863971, 1700841444);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3 a1 = uint3(1284069471, 194584707, 739120780);
            uint3 b1 = uint3(1044631301, 1391589821, 730837695);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3 a2 = uint3(241654068, 1340158550, 2099542537);
            uint3 b2 = uint3(253553987, 2078872742, 910845808);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3 a3 = uint3(1182623667, 1399607274, 789301637);
            uint3 b3 = uint3(976047676, 202633078, 1223618940);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_wide_scalar()
        {
            uint3 a0 = uint3(1097138316, 211763648, 1883002501);
            uint b0 = (438688675);
            bool3 r0 = bool3(true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3 a1 = uint3(56406996, 1923456111, 1437755186);
            uint b1 = (43662641);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3 a2 = uint3(1219010035, 304028799, 893125636);
            uint b2 = (2125058448);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3 a3 = uint3(48044515, 1035679270, 577943770);
            uint b3 = (711945018);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_scalar_wide()
        {
            uint a0 = (2024896938);
            uint3 b0 = uint3(599356784, 185671342, 1932327391);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (2025591013);
            uint3 b1 = uint3(1257191721, 1312388500, 1443698859);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (779217735);
            uint3 b2 = uint3(691047512, 741776730, 732565983);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (668302204);
            uint3 b3 = uint3(1556466996, 858599525, 1896917159);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_equal_wide_wide()
        {
            uint3 a0 = uint3(1577248162, 2043073061, 1688380407);
            uint3 b0 = uint3(903445031, 2108974565, 210822256);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3 a1 = uint3(176431985, 223299035, 1502802140);
            uint3 b1 = uint3(1281704747, 453681718, 66138830);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3 a2 = uint3(1691709825, 386789394, 117182003);
            uint3 b2 = uint3(1229799377, 1620922595, 1715833766);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3 a3 = uint3(1665770435, 1958490731, 420032601);
            uint3 b3 = uint3(1366430432, 13102000, 46919981);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_equal_wide_scalar()
        {
            uint3 a0 = uint3(1722165358, 1219858357, 860410743);
            uint b0 = (1688048545);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3 a1 = uint3(411099660, 1963256951, 212084836);
            uint b1 = (348104022);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3 a2 = uint3(58924407, 1745758438, 532949158);
            uint b2 = (1459242706);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3 a3 = uint3(262559763, 1806172431, 2091514001);
            uint b3 = (690091301);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_less_equal_scalar_wide()
        {
            uint a0 = (1777585);
            uint3 b0 = uint3(1181030049, 1787703989, 1729760948);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1816537388);
            uint3 b1 = uint3(1359786460, 874999193, 1678863148);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1711365839);
            uint3 b2 = uint3(762067160, 11953554, 1131583906);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1175393186);
            uint3 b3 = uint3(1293698493, 48893340, 66196247);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_equal_wide_wide()
        {
            uint3 a0 = uint3(263000030, 744235661, 1893760267);
            uint3 b0 = uint3(1395535146, 1178373944, 1237373760);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3 a1 = uint3(237248, 1062370984, 1676977687);
            uint3 b1 = uint3(1364855321, 600811864, 362060472);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3 a2 = uint3(816766880, 1089431546, 1394493730);
            uint3 b2 = uint3(290870624, 1839067862, 396958580);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3 a3 = uint3(1176473380, 1193988637, 1703862455);
            uint3 b3 = uint3(1336888643, 1019684398, 1697684196);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_equal_wide_scalar()
        {
            uint3 a0 = uint3(2112791350, 1043657935, 101764761);
            uint b0 = (1470533736);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3 a1 = uint3(1529909067, 281734132, 1186600258);
            uint b1 = (556026890);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3 a2 = uint3(815093894, 1604309397, 829548642);
            uint b2 = (609211196);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3 a3 = uint3(244604867, 471843809, 1819986195);
            uint b3 = (1419295004);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1525542481);
            uint3 b0 = uint3(1503244746, 861711266, 817773856);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (925984572);
            uint3 b1 = uint3(571221723, 683686810, 118252990);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1653952090);
            uint3 b2 = uint3(1240253990, 1947039008, 1869136019);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (152012637);
            uint3 b3 = uint3(1214546726, 917376832, 303549425);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_add_wide_wide()
        {
            uint3 a0 = uint3(2049228671, 1658660009, 491719392);
            uint3 b0 = uint3(2088751567, 645762023, 306868786);
            uint3 r0 = uint3(4137980238, 2304422032, 798588178);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3 a1 = uint3(937013355, 81108663, 1063894558);
            uint3 b1 = uint3(4360271, 506047997, 2094559874);
            uint3 r1 = uint3(941373626, 587156660, 3158454432);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3 a2 = uint3(86954702, 843159721, 698977704);
            uint3 b2 = uint3(1634712736, 1601474440, 1586485231);
            uint3 r2 = uint3(1721667438, 2444634161, 2285462935);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3 a3 = uint3(192867135, 1683407172, 137301303);
            uint3 b3 = uint3(908746788, 1812370320, 1247342357);
            uint3 r3 = uint3(1101613923, 3495777492, 1384643660);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_add_wide_scalar()
        {
            uint3 a0 = uint3(2038218457, 134923711, 875689667);
            uint b0 = (2124409227);
            uint3 r0 = uint3(4162627684, 2259332938, 3000098894);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3 a1 = uint3(1338884463, 340490871, 1067888129);
            uint b1 = (997710928);
            uint3 r1 = uint3(2336595391, 1338201799, 2065599057);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3 a2 = uint3(70433301, 1635971971, 1160398286);
            uint b2 = (2003021861);
            uint3 r2 = uint3(2073455162, 3638993832, 3163420147);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3 a3 = uint3(85446202, 1239387100, 1497676888);
            uint b3 = (1068152966);
            uint3 r3 = uint3(1153599168, 2307540066, 2565829854);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_add_scalar_wide()
        {
            uint a0 = (391092078);
            uint3 b0 = uint3(519908870, 851424292, 328314822);
            uint3 r0 = uint3(911000948, 1242516370, 719406900);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (135622204);
            uint3 b1 = uint3(740923360, 655394201, 1451896269);
            uint3 r1 = uint3(876545564, 791016405, 1587518473);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (1781697072);
            uint3 b2 = uint3(996031825, 1557774949, 779774940);
            uint3 r2 = uint3(2777728897, 3339472021, 2561472012);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (1111541302);
            uint3 b3 = uint3(783046445, 1130163944, 288279584);
            uint3 r3 = uint3(1894587747, 2241705246, 1399820886);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_sub_wide_wide()
        {
            uint3 a0 = uint3(1353441118, 797269833, 659988112);
            uint3 b0 = uint3(1332656812, 1827794007, 972557431);
            uint3 r0 = uint3(20784306, 3264443122, 3982397977);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3 a1 = uint3(56022121, 365847472, 2062899435);
            uint3 b1 = uint3(2078233689, 1508184327, 1372307701);
            uint3 r1 = uint3(2272755728, 3152630441, 690591734);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3 a2 = uint3(1380988474, 799885138, 1306058185);
            uint3 b2 = uint3(810327977, 936799885, 71562303);
            uint3 r2 = uint3(570660497, 4158052549, 1234495882);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3 a3 = uint3(579775276, 1239163824, 344591081);
            uint3 b3 = uint3(1418723328, 1971342989, 1226053395);
            uint3 r3 = uint3(3456019244, 3562788131, 3413504982);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_sub_wide_scalar()
        {
            uint3 a0 = uint3(1176369558, 1934521195, 309452150);
            uint b0 = (462232403);
            uint3 r0 = uint3(714137155, 1472288792, 4142187043);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3 a1 = uint3(1417634074, 1306356714, 1502312334);
            uint b1 = (108910717);
            uint3 r1 = uint3(1308723357, 1197445997, 1393401617);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3 a2 = uint3(1451794815, 87530840, 1913724431);
            uint b2 = (281174200);
            uint3 r2 = uint3(1170620615, 4101323936, 1632550231);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3 a3 = uint3(2041593336, 1119051448, 1590376732);
            uint b3 = (557239990);
            uint3 r3 = uint3(1484353346, 561811458, 1033136742);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_sub_scalar_wide()
        {
            uint a0 = (1691534405);
            uint3 b0 = uint3(2022393810, 1612688515, 496689713);
            uint3 r0 = uint3(3964107891, 78845890, 1194844692);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (887037586);
            uint3 b1 = uint3(2097630964, 374934538, 939035482);
            uint3 r1 = uint3(3084373918, 512103048, 4242969400);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (935242277);
            uint3 b2 = uint3(1789300421, 264712893, 1231856067);
            uint3 r2 = uint3(3440909152, 670529384, 3998353506);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1818112748);
            uint3 b3 = uint3(1428436109, 1258745460, 1077380396);
            uint3 r3 = uint3(389676639, 559367288, 740732352);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mul_wide_wide()
        {
            uint3 a0 = uint3(245827027, 208934650, 1019478917);
            uint3 b0 = uint3(759663997, 350129201, 477450108);
            uint3 r0 = uint3(3662155527, 1402281434, 332447596);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3 a1 = uint3(568231809, 877289039, 1585782440);
            uint3 b1 = uint3(1635735015, 388710278, 757722665);
            uint3 r1 = uint3(2361989735, 2624048730, 1455036648);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3 a2 = uint3(2111178729, 1186019069, 571481445);
            uint3 b2 = uint3(1509388321, 1841703980, 1826369331);
            uint3 r2 = uint3(2128344329, 3700879228, 2640799263);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3 a3 = uint3(1570087048, 629447153, 619383734);
            uint3 b3 = uint3(1524322467, 1605207974, 428419155);
            uint3 r3 = uint3(2093463192, 3087460678, 3161406466);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mul_wide_scalar()
        {
            uint3 a0 = uint3(1762033447, 465343930, 1570757881);
            uint b0 = (1476837906);
            uint3 r0 = uint3(2981789374, 1326807828, 2156411778);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3 a1 = uint3(1326409563, 1356578909, 72749215);
            uint b1 = (1824319147);
            uint3 r1 = uint3(4042902473, 4058582047, 2167403573);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3 a2 = uint3(154616909, 573770299, 1958912969);
            uint b2 = (975743632);
            uint3 r2 = uint3(7966032, 414773040, 262642448);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3 a3 = uint3(971327747, 1324050764, 660611671);
            uint b3 = (1818877398);
            uint3 r3 = uint3(2347605890, 1927061896, 2981154746);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mul_scalar_wide()
        {
            uint a0 = (99541948);
            uint3 b0 = uint3(1764461774, 657072478, 1459784358);
            uint3 r0 = uint3(3344568648, 4192918280, 1260585960);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1610646683);
            uint3 b1 = uint3(1632058826, 868441654, 1408757883);
            uint3 r1 = uint3(1644073294, 1407050418, 3474851449);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (335917146);
            uint3 b2 = uint3(2105124483, 1178393968, 1963904348);
            uint3 r2 = uint3(1003330062, 2631063904, 2268033624);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (1409533767);
            uint3 b3 = uint3(243286231, 1336308795, 517963367);
            uint3 r3 = uint3(108928161, 875895133, 2457018257);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_div_wide_wide()
        {
            uint3 a0 = uint3(1590198532, 507812502, 126627032);
            uint3 b0 = uint3(1434703236, 911965201, 390415521);
            uint3 r0 = uint3(1, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3 a1 = uint3(1058247011, 427387861, 290676154);
            uint3 b1 = uint3(128746927, 525835375, 816946613);
            uint3 r1 = uint3(8, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3 a2 = uint3(1829594484, 1127868739, 499016351);
            uint3 b2 = uint3(878264647, 146789678, 2089524057);
            uint3 r2 = uint3(2, 7, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3 a3 = uint3(1341209632, 134906097, 785470242);
            uint3 b3 = uint3(254213018, 1916850021, 1737806518);
            uint3 r3 = uint3(5, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_div_wide_scalar()
        {
            uint3 a0 = uint3(560951562, 1218680769, 375341724);
            uint b0 = (947861580);
            uint3 r0 = uint3(0, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3 a1 = uint3(1613542090, 1397425408, 1349573078);
            uint b1 = (1919409166);
            uint3 r1 = uint3(0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3 a2 = uint3(524526253, 495895326, 1515313790);
            uint b2 = (341995568);
            uint3 r2 = uint3(1, 1, 4);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3 a3 = uint3(1676971657, 2105094094, 1017891310);
            uint b3 = (2131487088);
            uint3 r3 = uint3(0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_div_scalar_wide()
        {
            uint a0 = (1161272038);
            uint3 b0 = uint3(187325733, 1594107378, 2016183849);
            uint3 r0 = uint3(6, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1589343709);
            uint3 b1 = uint3(388768753, 1417077283, 1773486938);
            uint3 r1 = uint3(4, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1154044032);
            uint3 b2 = uint3(81831373, 1476877645, 653688843);
            uint3 r2 = uint3(14, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (45756703);
            uint3 b3 = uint3(631027637, 396671391, 784365696);
            uint3 r3 = uint3(0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mod_wide_wide()
        {
            uint3 a0 = uint3(146150818, 1846543305, 1071447756);
            uint3 b0 = uint3(983050390, 771341152, 942375212);
            uint3 r0 = uint3(146150818, 303861001, 129072544);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3 a1 = uint3(308965362, 659881575, 1002365460);
            uint3 b1 = uint3(367361754, 749500619, 750718852);
            uint3 r1 = uint3(308965362, 659881575, 251646608);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3 a2 = uint3(861198439, 1510617532, 778525078);
            uint3 b2 = uint3(2095151755, 88438806, 769227442);
            uint3 r2 = uint3(861198439, 7157830, 9297636);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3 a3 = uint3(1458458044, 101987897, 1249565173);
            uint3 b3 = uint3(647214624, 1026513788, 1544950956);
            uint3 r3 = uint3(164028796, 101987897, 1249565173);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mod_wide_scalar()
        {
            uint3 a0 = uint3(164800505, 1062177828, 1898749675);
            uint b0 = (883951171);
            uint3 r0 = uint3(164800505, 178226657, 130847333);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3 a1 = uint3(1701653318, 19002208, 128329633);
            uint b1 = (820393245);
            uint3 r1 = uint3(60866828, 19002208, 128329633);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3 a2 = uint3(1464010899, 405208598, 1982762194);
            uint b2 = (896587769);
            uint3 r2 = uint3(567423130, 405208598, 189586656);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3 a3 = uint3(959236935, 172564850, 1540068445);
            uint b3 = (712321026);
            uint3 r3 = uint3(246915909, 172564850, 115426393);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_mod_scalar_wide()
        {
            uint a0 = (242383789);
            uint3 b0 = uint3(740000543, 1556450291, 1104736385);
            uint3 r0 = uint3(242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (437976569);
            uint3 b1 = uint3(1911837205, 1507212038, 1906405167);
            uint3 r1 = uint3(437976569, 437976569, 437976569);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (247693265);
            uint3 b2 = uint3(293460573, 1495295166, 873323603);
            uint3 r2 = uint3(247693265, 247693265, 247693265);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (530681233);
            uint3 b3 = uint3(1298102643, 2057984657, 1000742091);
            uint3 r3 = uint3(530681233, 530681233, 530681233);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_plus()
        {
            uint3 a0 = uint3(1643476803, 907898539, 379615839);
            uint3 r0 = uint3(1643476803, 907898539, 379615839);
            TestUtils.AreEqual(+a0, r0);

            uint3 a1 = uint3(1140483021, 1743199272, 1472881565);
            uint3 r1 = uint3(1140483021, 1743199272, 1472881565);
            TestUtils.AreEqual(+a1, r1);

            uint3 a2 = uint3(339091479, 1287765427, 849339193);
            uint3 r2 = uint3(339091479, 1287765427, 849339193);
            TestUtils.AreEqual(+a2, r2);

            uint3 a3 = uint3(174532915, 1566098441, 1145639744);
            uint3 r3 = uint3(174532915, 1566098441, 1145639744);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_neg()
        {
            uint3 a0 = uint3(1955022112, 662160019, 370300775);
            uint3 r0 = uint3(2339945184, 3632807277, 3924666521);
            TestUtils.AreEqual(-a0, r0);

            uint3 a1 = uint3(2141283773, 28153593, 33894270);
            uint3 r1 = uint3(2153683523, 4266813703, 4261073026);
            TestUtils.AreEqual(-a1, r1);

            uint3 a2 = uint3(505708349, 1636274969, 694995093);
            uint3 r2 = uint3(3789258947, 2658692327, 3599972203);
            TestUtils.AreEqual(-a2, r2);

            uint3 a3 = uint3(1542206286, 243937487, 341522275);
            uint3 r3 = uint3(2752761010, 4051029809, 3953445021);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_prefix_inc()
        {
            uint3 a0 = uint3(864455342, 2035793213, 1275443862);
            uint3 r0 = uint3(864455343, 2035793214, 1275443863);
            TestUtils.AreEqual(++a0, r0);

            uint3 a1 = uint3(971919915, 446210725, 395072276);
            uint3 r1 = uint3(971919916, 446210726, 395072277);
            TestUtils.AreEqual(++a1, r1);

            uint3 a2 = uint3(115573442, 432884105, 1208161871);
            uint3 r2 = uint3(115573443, 432884106, 1208161872);
            TestUtils.AreEqual(++a2, r2);

            uint3 a3 = uint3(1385544935, 831396561, 388229350);
            uint3 r3 = uint3(1385544936, 831396562, 388229351);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_postfix_inc()
        {
            uint3 a0 = uint3(1751003569, 2063707595, 1500486291);
            uint3 r0 = uint3(1751003569, 2063707595, 1500486291);
            TestUtils.AreEqual(a0++, r0);

            uint3 a1 = uint3(969189211, 2028651936, 1643023524);
            uint3 r1 = uint3(969189211, 2028651936, 1643023524);
            TestUtils.AreEqual(a1++, r1);

            uint3 a2 = uint3(1190630527, 708474528, 177416855);
            uint3 r2 = uint3(1190630527, 708474528, 177416855);
            TestUtils.AreEqual(a2++, r2);

            uint3 a3 = uint3(1524860667, 375284401, 1580130369);
            uint3 r3 = uint3(1524860667, 375284401, 1580130369);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void uint3_operator_prefix_dec()
        {
            uint3 a0 = uint3(200904609, 871077500, 968578728);
            uint3 r0 = uint3(200904608, 871077499, 968578727);
            TestUtils.AreEqual(--a0, r0);

            uint3 a1 = uint3(638967721, 435367037, 1782514098);
            uint3 r1 = uint3(638967720, 435367036, 1782514097);
            TestUtils.AreEqual(--a1, r1);

            uint3 a2 = uint3(1589827826, 596759698, 1699290403);
            uint3 r2 = uint3(1589827825, 596759697, 1699290402);
            TestUtils.AreEqual(--a2, r2);

            uint3 a3 = uint3(1758478358, 71237375, 389120307);
            uint3 r3 = uint3(1758478357, 71237374, 389120306);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_postfix_dec()
        {
            uint3 a0 = uint3(283970262, 1109329936, 1073216143);
            uint3 r0 = uint3(283970262, 1109329936, 1073216143);
            TestUtils.AreEqual(a0--, r0);

            uint3 a1 = uint3(649439137, 1174104498, 484207852);
            uint3 r1 = uint3(649439137, 1174104498, 484207852);
            TestUtils.AreEqual(a1--, r1);

            uint3 a2 = uint3(524156737, 2017728859, 802721301);
            uint3 r2 = uint3(524156737, 2017728859, 802721301);
            TestUtils.AreEqual(a2--, r2);

            uint3 a3 = uint3(377162390, 1504625034, 590919177);
            uint3 r3 = uint3(377162390, 1504625034, 590919177);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_and_wide_wide()
        {
            uint3 a0 = uint3(779935043, 1097962163, 1939593304);
            uint3 b0 = uint3(307705143, 1710882162, 866836769);
            uint3 r0 = uint3(39064835, 1097961522, 864731136);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3 a1 = uint3(800599247, 952140918, 782792558);
            uint3 b1 = uint3(532490608, 679371720, 1794035877);
            uint3 r1 = uint3(263727168, 675283008, 715673636);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3 a2 = uint3(1608557706, 396446406, 2039894114);
            uint3 b2 = uint3(1439832202, 519529812, 23633139);
            uint3 r2 = uint3(1438646410, 379666500, 16781410);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3 a3 = uint3(1286974642, 442394124, 1759739564);
            uint3 b3 = uint3(1209152681, 646737179, 1255867027);
            uint3 r3 = uint3(1209017504, 34366472, 1220739712);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_and_wide_scalar()
        {
            uint3 a0 = uint3(443615469, 490057985, 2042441263);
            uint b0 = (93423598);
            uint3 r0 = uint3(1114348, 85033216, 26281518);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3 a1 = uint3(1524760558, 510212004, 1941875181);
            uint b1 = (1405175110);
            uint3 r1 = uint3(1388397894, 306251012, 1400897860);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3 a2 = uint3(1236735839, 428270198, 607982857);
            uint b2 = (1365509729);
            uint3 r2 = uint3(1092879937, 285475424, 2360321);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3 a3 = uint3(650270920, 814629680, 1862276471);
            uint b3 = (1249238550);
            uint3 r3 = uint3(37771264, 279056, 1241519126);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1144543590);
            uint3 b0 = uint3(420346723, 562416448, 1393127318);
            uint3 r0 = uint3(547170, 18752, 1074284806);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1560699552);
            uint3 b1 = uint3(851218057, 703880958, 1159378889);
            uint3 r1 = uint3(268698240, 151274144, 1157767808);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (2031211279);
            uint3 b2 = uint3(1089518981, 270607307, 1349288930);
            uint3 r2 = uint3(1074827525, 268501771, 1342210818);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (520199596);
            uint3 b3 = uint3(1763483957, 1248975349, 236938635);
            uint3 r3 = uint3(151028004, 167877028, 234947976);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_or_wide_wide()
        {
            uint3 a0 = uint3(1731159103, 659068416, 382702471);
            uint3 b0 = uint3(1583847161, 692672727, 1161585489);
            uint3 r0 = uint3(2138044159, 793370327, 1476391895);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3 a1 = uint3(1821032196, 1565773438, 1004000514);
            uint3 b1 = uint3(1756207130, 1321374429, 1287357212);
            uint3 r1 = uint3(1823457054, 1607720703, 2147473182);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3 a2 = uint3(948501377, 600951835, 669346222);
            uint3 b2 = uint3(2075767170, 1273513430, 1610830169);
            uint3 r2 = uint3(2075786115, 1811533279, 1743223295);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3 a3 = uint3(396691477, 2108560248, 2117522137);
            uint3 b3 = uint3(1316929125, 511625048, 573925879);
            uint3 r3 = uint3(1610595957, 2147407736, 2117598207);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_or_wide_scalar()
        {
            uint3 a0 = uint3(961259683, 471103264, 1733389229);
            uint b0 = (1666102508);
            uint3 r0 = uint3(2068823279, 2136930284, 1734344685);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3 a1 = uint3(1591585258, 1148351449, 1048929715);
            uint b1 = (386953869);
            uint3 r1 = uint3(1608383471, 1467118557, 1066760127);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3 a2 = uint3(1814263250, 1637162093, 1227888278);
            uint b2 = (860336789);
            uint3 r2 = uint3(2137520087, 1943518973, 2071443095);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3 a3 = uint3(774029856, 1179087439, 797240690);
            uint b3 = (879300408);
            uint3 r3 = uint3(1047252792, 1987018623, 1072557946);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1213433101);
            uint3 b0 = uint3(1212928242, 1614462616, 936937728);
            uint3 r0 = uint3(1213978111, 1752940445, 2145094925);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (764766995);
            uint3 b1 = uint3(306352095, 574719481, 1283571271);
            uint3 r1 = uint3(1071116255, 802549755, 1838546775);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (2109131012);
            uint3 b2 = uint3(979469710, 1348323481, 1407542578);
            uint3 r2 = uint3(2146946446, 2113915293, 2146954550);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (697517649);
            uint3 b3 = uint3(1059093741, 627815046, 418822515);
            uint3 r3 = uint3(1068728061, 771487447, 972554099);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_xor_wide_wide()
        {
            uint3 a0 = uint3(1556324760, 207002929, 1843444873);
            uint3 b0 = uint3(1054997548, 1523759632, 251164872);
            uint3 r0 = uint3(1646419380, 1451501345, 1662567489);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3 a1 = uint3(1632079131, 1460334334, 1607815585);
            uint3 b1 = uint3(110472397, 384031112, 1109163205);
            uint3 r1 = uint3(1741824470, 1105803126, 499723620);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3 a2 = uint3(220623650, 38668553, 47193340);
            uint3 b2 = uint3(535118981, 179106262, 1523031711);
            uint3 r2 = uint3(314783655, 149092575, 1477935715);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3 a3 = uint3(643663548, 1371932564, 94957188);
            uint3 b3 = uint3(1713313372, 1294118730, 520360641);
            uint3 r3 = uint3(1078104288, 484747486, 447544389);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_xor_wide_scalar()
        {
            uint3 a0 = uint3(2124666952, 177397845, 574879617);
            uint b0 = (493665894);
            uint3 r0 = uint3(1674536494, 402546227, 1060063719);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3 a1 = uint3(1937385541, 213863690, 535061373);
            uint b1 = (1136545648);
            uint3 r1 = uint3(818177845, 1325466234, 1549413389);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3 a2 = uint3(289301586, 353786540, 1308626970);
            uint b2 = (1305234431);
            uint3 r2 = uint3(1559375789, 1490686291, 63724517);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3 a3 = uint3(1267729267, 1315625690, 1730088797);
            uint b3 = (125659640);
            uint3 r3 = uint3(1290627723, 1226289954, 1617061541);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1288453276);
            uint3 b0 = uint3(1077599928, 884741329, 212164516);
            uint3 r0 = uint3(217506340, 2020616269, 1080648504);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1585020328);
            uint3 b1 = uint3(152985454, 1775851275, 1416249064);
            uint3 r1 = uint3(1466376902, 933243555, 169034560);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1309317737);
            uint3 b2 = uint3(1773918217, 1509843030, 1206045972);
            uint3 r2 = uint3(665928288, 401930815, 166221693);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1154916424);
            uint3 b3 = uint3(1947871003, 1774252400, 1946113778);
            uint3 r3 = uint3(818710355, 756437304, 925497018);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_left_shift()
        {
            uint3 a0 = uint3(197771193, 622182602, 1283988958);
            int b0 = (1321149625);
            uint3 r0 = uint3(1912602624, 2483027968, 3154116608);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3 a1 = uint3(1327917304, 432425717, 870301196);
            int b1 = (473415985);
            uint3 r1 = uint3(3522166784, 2515140608, 2081947648);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3 a2 = uint3(2058433484, 1531607705, 1360008038);
            int b2 = (1200694230);
            uint3 r2 = uint3(4076863488, 2789212160, 3649044480);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3 a3 = uint3(1008296534, 1079614371, 35667343);
            int b3 = (1447702302);
            uint3 r3 = uint3(2147483648, 3221225472, 3221225472);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_right_shift()
        {
            uint3 a0 = uint3(548167301, 1161338299, 1617625829);
            int b0 = (1266801540);
            uint3 r0 = uint3(34260456, 72583643, 101101614);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3 a1 = uint3(1860731847, 196552656, 770466193);
            int b1 = (713958715);
            uint3 r1 = uint3(13, 1, 5);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3 a2 = uint3(1265099998, 506619530, 426807581);
            int b2 = (572763124);
            uint3 r2 = uint3(1206, 483, 407);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3 a3 = uint3(2031319045, 917785020, 569504877);
            int b3 = (701927980);
            uint3 r3 = uint3(495927, 224068, 139039);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void uint3_operator_bitwise_not()
        {
            uint3 a0 = uint3(1403358969, 831360921, 2088190243);
            uint3 r0 = uint3(2891608326, 3463606374, 2206777052);
            TestUtils.AreEqual(~a0, r0);

            uint3 a1 = uint3(976721016, 308994339, 1935567517);
            uint3 r1 = uint3(3318246279, 3985972956, 2359399778);
            TestUtils.AreEqual(~a1, r1);

            uint3 a2 = uint3(1420884856, 771711426, 627580960);
            uint3 r2 = uint3(2874082439, 3523255869, 3667386335);
            TestUtils.AreEqual(~a2, r2);

            uint3 a3 = uint3(2061524024, 2097179283, 1303022493);
            uint3 r3 = uint3(2233443271, 2197788012, 2991944802);
            TestUtils.AreEqual(~a3, r3);
        }

        [TestCompiler]
        public static void uint3_shuffle_result_1()
        {
            uint3 a = uint3(0, 1, 2);
            uint3 b = uint3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (5));
        }

        [TestCompiler]
        public static void uint3_shuffle_result_2()
        {
            uint3 a = uint3(0, 1, 2);
            uint3 b = uint3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), uint2(4, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), uint2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), uint2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY), uint2(5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), uint2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftZ), uint2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), uint2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), uint2(5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), uint2(4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), uint2(4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), uint2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), uint2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY), uint2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), uint2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), uint2(1, 2));
        }

        [TestCompiler]
        public static void uint3_shuffle_result_3()
        {
            uint3 a = uint3(0, 1, 2);
            uint3 b = uint3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.RightX), uint3(1, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), uint3(4, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX), uint3(2, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY), uint3(4, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.LeftZ), uint3(5, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.LeftY), uint3(2, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightX), uint3(2, 4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftY, ShuffleComponent.RightZ), uint3(2, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ), uint3(4, 4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), uint3(4, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), uint3(5, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint3(5, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightZ), uint3(4, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightY), uint3(2, 3, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint3(4, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightZ), uint3(4, 0, 5));
        }

        [TestCompiler]
        public static void uint3_shuffle_result_4()
        {
            uint3 a = uint3(0, 1, 2);
            uint3 b = uint3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY), uint4(1, 2, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightY), uint4(4, 2, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.LeftY), uint4(4, 4, 5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint4(3, 3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), uint4(4, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightZ), uint4(3, 4, 3, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightZ), uint4(1, 5, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), uint4(4, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightZ, ShuffleComponent.LeftZ, ShuffleComponent.LeftX), uint4(3, 5, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint4(4, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), uint4(0, 2, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.RightZ), uint4(1, 4, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint4(2, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), uint4(3, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(5, 3, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(2, 5, 0, 4));
        }


    }
}
