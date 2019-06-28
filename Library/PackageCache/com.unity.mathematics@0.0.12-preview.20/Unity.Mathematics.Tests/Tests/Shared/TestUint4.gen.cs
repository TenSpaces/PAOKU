// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint4
    {
        [TestCompiler]
        public static void uint4_zero()
        {
            TestUtils.AreEqual(uint4.zero.x, 0u);
            TestUtils.AreEqual(uint4.zero.y, 0u);
            TestUtils.AreEqual(uint4.zero.z, 0u);
            TestUtils.AreEqual(uint4.zero.w, 0u);
        }

        [TestCompiler]
        public static void uint4_constructor()
        {
            uint4 a = new uint4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public static void uint4_scalar_constructor()
        {
            uint4 a = new uint4(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
            TestUtils.AreEqual(a.z, 17u);
            TestUtils.AreEqual(a.w, 17u);
        }

        [TestCompiler]
        public static void uint4_static_constructor()
        {
            uint4 a = uint4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public static void uint4_static_scalar_constructor()
        {
            uint4 a = uint4(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
            TestUtils.AreEqual(a.z, 17u);
            TestUtils.AreEqual(a.w, 17u);
        }

        [TestCompiler]
        public static void uint4_operator_equal_wide_wide()
        {
            uint4 a0 = uint4(790229414, 970783976, 1428432738, 1578747135);
            uint4 b0 = uint4(612337669, 1214209108, 2120643427, 295461214);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(1733797753, 2001507228, 1446876437, 1777406370);
            uint4 b1 = uint4(1510890331, 1893316566, 921816149, 1834958575);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(1426387268, 1809275021, 1843770816, 1172185222);
            uint4 b2 = uint4(1482011863, 2062852792, 226398742, 770290735);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(1469608940, 869874758, 458603090, 581282460);
            uint4 b3 = uint4(36812057, 543224481, 1565350150, 1909926604);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_equal_wide_scalar()
        {
            uint4 a0 = uint4(1211464300, 1921862607, 508076684, 1249127920);
            uint b0 = (746972502);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(1394594555, 1733655277, 1884008277, 1682018538);
            uint b1 = (746862310);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(795585660, 927605411, 672785749, 1465584610);
            uint b2 = (936027116);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(585324157, 969511077, 442746747, 1772925698);
            uint b3 = (404448210);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_equal_scalar_wide()
        {
            uint a0 = (1150044438);
            uint4 b0 = uint4(233855098, 924242519, 1402948791, 601381975);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (2120518068);
            uint4 b1 = uint4(629187703, 1971977031, 47183124, 1061805787);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (1009011238);
            uint4 b2 = uint4(312511148, 1460673064, 737210539, 1737844479);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1892405453);
            uint4 b3 = uint4(2133024000, 455818693, 2003197687, 1276241219);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_not_equal_wide_wide()
        {
            uint4 a0 = uint4(1660932106, 982847023, 97046264, 1739517447);
            uint4 b0 = uint4(107139049, 75478496, 2055495054, 358586687);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(1253499180, 1830584069, 1841470429, 1397841646);
            uint4 b1 = uint4(942338347, 111564990, 113811950, 948912488);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(1770890135, 1906548631, 169082967, 2099271786);
            uint4 b2 = uint4(1080084121, 1400504872, 1032134499, 1061123400);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(1909317609, 46519139, 1433204003, 931492669);
            uint4 b3 = uint4(221862069, 858950046, 989094643, 2023070999);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_not_equal_wide_scalar()
        {
            uint4 a0 = uint4(747758183, 1033001286, 1439973882, 2138928797);
            uint b0 = (248693828);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(1197845089, 950170763, 238704450, 2105962247);
            uint b1 = (1432672459);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(727205263, 276313906, 2126300423, 791998981);
            uint b2 = (1640688041);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(2035077187, 1412347883, 1622176923, 768370497);
            uint b3 = (1171827730);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_not_equal_scalar_wide()
        {
            uint a0 = (2076921066);
            uint4 b0 = uint4(2037494727, 1989050616, 48833929, 1897435904);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (514354517);
            uint4 b1 = uint4(1783749164, 364694471, 754315072, 124108032);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1512967900);
            uint4 b2 = uint4(1178825850, 1854793298, 50286949, 2100802631);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1640811853);
            uint4 b3 = uint4(82110247, 472172806, 266984506, 2003668365);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_wide_wide()
        {
            uint4 a0 = uint4(1182186063, 415538999, 1667335818, 1566618442);
            uint4 b0 = uint4(524633529, 1032195686, 760723389, 1505751409);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(1166180837, 639095188, 1080836365, 771119973);
            uint4 b1 = uint4(431962172, 1287906509, 1560084663, 1450178202);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(928263233, 789225474, 665243110, 1003542034);
            uint4 b2 = uint4(2066166337, 1107069023, 1640077524, 2103263105);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(1032480172, 1961336172, 923379558, 21210619);
            uint4 b3 = uint4(684229139, 1234033624, 1278743281, 1953079347);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_wide_scalar()
        {
            uint4 a0 = uint4(608447185, 818840405, 869219329, 2080125385);
            uint b0 = (1491216667);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(1214500548, 1667165786, 1615392341, 840091491);
            uint b1 = (1361741203);
            bool4 r1 = bool4(true, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(469591900, 315321650, 930950514, 1100560246);
            uint b2 = (1247103789);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(933855388, 1127696709, 1286331950, 380753337);
            uint b3 = (908563901);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_scalar_wide()
        {
            uint a0 = (548436837);
            uint4 b0 = uint4(282703327, 14370648, 1862117300, 1304793311);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (826073259);
            uint4 b1 = uint4(988910157, 445132446, 1139670255, 111349251);
            bool4 r1 = bool4(true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1102440676);
            uint4 b2 = uint4(112183144, 1594415311, 1890019295, 2098715503);
            bool4 r2 = bool4(false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (608933527);
            uint4 b3 = uint4(183989010, 1596056507, 1027318999, 146281093);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_wide_wide()
        {
            uint4 a0 = uint4(592884447, 2133928932, 918957182, 1284069471);
            uint4 b0 = uint4(138737040, 192863971, 1700841444, 1044631301);
            bool4 r0 = bool4(true, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(194584707, 739120780, 241654068, 1340158550);
            uint4 b1 = uint4(1391589821, 730837695, 253553987, 2078872742);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(2099542537, 1182623667, 1399607274, 789301637);
            uint4 b2 = uint4(910845808, 976047676, 202633078, 1223618940);
            bool4 r2 = bool4(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(180400925, 594688333, 1877031463, 1360073500);
            uint4 b3 = uint4(641600530, 1830470354, 1570701388, 1104256103);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_wide_scalar()
        {
            uint4 a0 = uint4(1097138316, 211763648, 1883002501, 56406996);
            uint b0 = (438688675);
            bool4 r0 = bool4(true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(43662641, 1437755186, 1219010035, 2125058448);
            uint b1 = (1923456111);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(304028799, 48044515, 711945018, 1035679270);
            uint b2 = (893125636);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(577943770, 1016617211, 2063134811, 1577403353);
            uint b3 = (572743717);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_scalar_wide()
        {
            uint a0 = (2024896938);
            uint4 b0 = uint4(599356784, 185671342, 1932327391, 2025591013);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1257191721);
            uint4 b1 = uint4(1312388500, 1443698859, 779217735, 691047512);
            bool4 r1 = bool4(false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (741776730);
            uint4 b2 = uint4(732565983, 668302204, 1556466996, 858599525);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (1896917159);
            uint4 b3 = uint4(701542098, 1052151621, 1023307544, 1435392907);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_equal_wide_wide()
        {
            uint4 a0 = uint4(1577248162, 2043073061, 1688380407, 176431985);
            uint4 b0 = uint4(903445031, 2108974565, 210822256, 1281704747);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(223299035, 1502802140, 1691709825, 386789394);
            uint4 b1 = uint4(453681718, 66138830, 1229799377, 1620922595);
            bool4 r1 = bool4(true, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(117182003, 1665770435, 1958490731, 420032601);
            uint4 b2 = uint4(1715833766, 1366430432, 13102000, 46919981);
            bool4 r2 = bool4(true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(1251092689, 2011681765, 749743684, 183784440);
            uint4 b3 = uint4(486470891, 1709514236, 2145785285, 854254454);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_equal_wide_scalar()
        {
            uint4 a0 = uint4(1722165358, 1219858357, 860410743, 411099660);
            uint b0 = (1688048545);
            bool4 r0 = bool4(false, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(348104022, 212084836, 58924407, 1459242706);
            uint b1 = (1963256951);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(1745758438, 262559763, 690091301, 1806172431);
            uint b2 = (532949158);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(2091514001, 1617221948, 2017733017, 804204255);
            uint b3 = (1857173043);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_less_equal_scalar_wide()
        {
            uint a0 = (1777585);
            uint4 b0 = uint4(1181030049, 1787703989, 1729760948, 1816537388);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1359786460);
            uint4 b1 = uint4(874999193, 1678863148, 1711365839, 762067160);
            bool4 r1 = bool4(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (11953554);
            uint4 b2 = uint4(1131583906, 1175393186, 1293698493, 48893340);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (66196247);
            uint4 b3 = uint4(1958607116, 1576473309, 861890786, 478252419);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_equal_wide_wide()
        {
            uint4 a0 = uint4(263000030, 744235661, 1893760267, 237248);
            uint4 b0 = uint4(1395535146, 1178373944, 1237373760, 1364855321);
            bool4 r0 = bool4(false, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(1062370984, 1676977687, 816766880, 1089431546);
            uint4 b1 = uint4(600811864, 362060472, 290870624, 1839067862);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(1394493730, 1176473380, 1193988637, 1703862455);
            uint4 b2 = uint4(396958580, 1336888643, 1019684398, 1697684196);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(1806186947, 1253571980, 589397635, 1951842887);
            uint4 b3 = uint4(1227300220, 2044269675, 1898323839, 874509380);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_equal_wide_scalar()
        {
            uint4 a0 = uint4(2112791350, 1043657935, 101764761, 1529909067);
            uint b0 = (1470533736);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(556026890, 1186600258, 815093894, 609211196);
            uint b1 = (281734132);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(1604309397, 244604867, 1419295004, 471843809);
            uint b2 = (829548642);
            bool4 r2 = bool4(true, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(1819986195, 1646290021, 196833647, 1596738181);
            uint b3 = (1460027917);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1525542481);
            uint4 b0 = uint4(1503244746, 861711266, 817773856, 925984572);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (571221723);
            uint4 b1 = uint4(683686810, 118252990, 1653952090, 1240253990);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1947039008);
            uint4 b2 = uint4(1869136019, 152012637, 1214546726, 917376832);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (303549425);
            uint4 b3 = uint4(2111728811, 945321577, 173706579, 625318949);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_add_wide_wide()
        {
            uint4 a0 = uint4(2049228671, 1658660009, 491719392, 937013355);
            uint4 b0 = uint4(2088751567, 645762023, 306868786, 4360271);
            uint4 r0 = uint4(4137980238, 2304422032, 798588178, 941373626);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(81108663, 1063894558, 86954702, 843159721);
            uint4 b1 = uint4(506047997, 2094559874, 1634712736, 1601474440);
            uint4 r1 = uint4(587156660, 3158454432, 1721667438, 2444634161);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(698977704, 192867135, 1683407172, 137301303);
            uint4 b2 = uint4(1586485231, 908746788, 1812370320, 1247342357);
            uint4 r2 = uint4(2285462935, 1101613923, 3495777492, 1384643660);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(2103582820, 526139155, 447937230, 2127411006);
            uint4 b3 = uint4(2043773873, 223363428, 175115707, 985928617);
            uint4 r3 = uint4(4147356693, 749502583, 623052937, 3113339623);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_add_wide_scalar()
        {
            uint4 a0 = uint4(2038218457, 134923711, 875689667, 1338884463);
            uint b0 = (2124409227);
            uint4 r0 = uint4(4162627684, 2259332938, 3000098894, 3463293690);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(997710928, 1067888129, 70433301, 2003021861);
            uint b1 = (340490871);
            uint4 r1 = uint4(1338201799, 1408379000, 410924172, 2343512732);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(1635971971, 85446202, 1068152966, 1239387100);
            uint b2 = (1160398286);
            uint4 r2 = uint4(2796370257, 1245844488, 2228551252, 2399785386);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(1497676888, 1095438654, 756559204, 1818718931);
            uint b3 = (1727477485);
            uint4 r3 = uint4(3225154373, 2822916139, 2484036689, 3546196416);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_add_scalar_wide()
        {
            uint a0 = (391092078);
            uint4 b0 = uint4(519908870, 851424292, 328314822, 135622204);
            uint4 r0 = uint4(911000948, 1242516370, 719406900, 526714282);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (740923360);
            uint4 b1 = uint4(655394201, 1451896269, 1781697072, 996031825);
            uint4 r1 = uint4(1396317561, 2192819629, 2522620432, 1736955185);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (1557774949);
            uint4 b2 = uint4(779774940, 1111541302, 783046445, 1130163944);
            uint4 r2 = uint4(2337549889, 2669316251, 2340821394, 2687938893);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (288279584);
            uint4 b3 = uint4(1397683861, 1636583489, 673263339, 1469300874);
            uint4 r3 = uint4(1685963445, 1924863073, 961542923, 1757580458);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_sub_wide_wide()
        {
            uint4 a0 = uint4(1353441118, 797269833, 659988112, 56022121);
            uint4 b0 = uint4(1332656812, 1827794007, 972557431, 2078233689);
            uint4 r0 = uint4(20784306, 3264443122, 3982397977, 2272755728);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(365847472, 2062899435, 1380988474, 799885138);
            uint4 b1 = uint4(1508184327, 1372307701, 810327977, 936799885);
            uint4 r1 = uint4(3152630441, 690591734, 570660497, 4158052549);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(1306058185, 579775276, 1239163824, 344591081);
            uint4 b2 = uint4(71562303, 1418723328, 1971342989, 1226053395);
            uint4 r2 = uint4(1234495882, 3456019244, 3562788131, 3413504982);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(86359575, 1049709943, 721529513, 1767221271);
            uint4 b3 = uint4(136565478, 1979903295, 600719425, 837912956);
            uint4 r3 = uint4(4244761393, 3364773944, 120810088, 929308315);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_sub_wide_scalar()
        {
            uint4 a0 = uint4(1176369558, 1934521195, 309452150, 1417634074);
            uint b0 = (462232403);
            uint4 r0 = uint4(714137155, 1472288792, 4142187043, 955401671);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(108910717, 1502312334, 1451794815, 281174200);
            uint b1 = (1306356714);
            uint4 r1 = uint4(3097521299, 195955620, 145438101, 3269784782);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(87530840, 2041593336, 557239990, 1119051448);
            uint b2 = (1913724431);
            uint4 r2 = uint4(2468773705, 127868905, 2938482855, 3500294313);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(1590376732, 816382635, 815920639, 1829033117);
            uint b3 = (819090189);
            uint4 r3 = uint4(771286543, 4292259742, 4291797746, 1009942928);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_sub_scalar_wide()
        {
            uint a0 = (1691534405);
            uint4 b0 = uint4(2022393810, 1612688515, 496689713, 887037586);
            uint4 r0 = uint4(3964107891, 78845890, 1194844692, 804496819);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (2097630964);
            uint4 b1 = uint4(374934538, 939035482, 935242277, 1789300421);
            uint4 r1 = uint4(1722696426, 1158595482, 1162388687, 308330543);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (264712893);
            uint4 b2 = uint4(1231856067, 1818112748, 1428436109, 1258745460);
            uint4 r2 = uint4(3327824122, 2741567441, 3131244080, 3300934729);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1077380396);
            uint4 b3 = uint4(1330722719, 518111829, 967128529, 344666254);
            uint4 r3 = uint4(4041624973, 559268567, 110251867, 732714142);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mul_wide_wide()
        {
            uint4 a0 = uint4(245827027, 208934650, 1019478917, 568231809);
            uint4 b0 = uint4(759663997, 350129201, 477450108, 1635735015);
            uint4 r0 = uint4(3662155527, 1402281434, 332447596, 2361989735);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(877289039, 1585782440, 2111178729, 1186019069);
            uint4 b1 = uint4(388710278, 757722665, 1509388321, 1841703980);
            uint4 r1 = uint4(2624048730, 1455036648, 2128344329, 3700879228);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(571481445, 1570087048, 629447153, 619383734);
            uint4 b2 = uint4(1826369331, 1524322467, 1605207974, 428419155);
            uint4 r2 = uint4(2640799263, 2093463192, 3087460678, 3161406466);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(2055121568, 700402816, 263414349, 187830569);
            uint4 b3 = uint4(1460605791, 1968043860, 771161742, 2037340417);
            uint4 r3 = uint4(990589280, 3356793344, 2953243830, 1156600361);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mul_wide_scalar()
        {
            uint4 a0 = uint4(1762033447, 465343930, 1570757881, 1326409563);
            uint b0 = (1476837906);
            uint4 r0 = uint4(2981789374, 1326807828, 2156411778, 4018813542);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(1824319147, 72749215, 154616909, 975743632);
            uint b1 = (1356578909);
            uint4 r1 = uint4(4058582047, 130042307, 1244434425, 2313287248);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(573770299, 971327747, 1818877398, 1324050764);
            uint b2 = (1958912969);
            uint4 r2 = uint4(3595344211, 583613531, 2609540870, 377032876);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(660611671, 391009467, 1186856590, 890343818);
            uint b3 = (1279757657);
            uint4 r3 = uint4(4252425023, 1120105475, 4272141662, 1972017914);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mul_scalar_wide()
        {
            uint a0 = (99541948);
            uint4 b0 = uint4(1764461774, 657072478, 1459784358, 1610646683);
            uint4 r0 = uint4(3344568648, 4192918280, 1260585960, 1158730452);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1632058826);
            uint4 b1 = uint4(868441654, 1408757883, 335917146, 2105124483);
            uint4 r1 = uint4(4237636764, 2735607822, 712546564, 3489634910);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1178393968);
            uint4 b2 = uint4(1963904348, 1409533767, 243286231, 1336308795);
            uint4 r2 = uint4(1196573760, 592673296, 209320208, 3942500560);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (517963367);
            uint4 b3 = uint4(1733623488, 459880225, 994616533, 1420531535);
            uint4 r3 = uint4(3520397120, 3023465543, 652617651, 2505294537);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_div_wide_wide()
        {
            uint4 a0 = uint4(1590198532, 507812502, 126627032, 1058247011);
            uint4 b0 = uint4(1434703236, 911965201, 390415521, 128746927);
            uint4 r0 = uint4(1, 0, 0, 8);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(427387861, 290676154, 1829594484, 1127868739);
            uint4 b1 = uint4(525835375, 816946613, 878264647, 146789678);
            uint4 r1 = uint4(0, 0, 2, 7);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(499016351, 1341209632, 134906097, 785470242);
            uint4 b2 = uint4(2089524057, 254213018, 1916850021, 1737806518);
            uint4 r2 = uint4(0, 5, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(788249865, 1099825433, 1552968283, 1822367139);
            uint4 b3 = uint4(1906634983, 437754923, 825037958, 902508708);
            uint4 r3 = uint4(0, 2, 1, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_div_wide_scalar()
        {
            uint4 a0 = uint4(560951562, 1218680769, 375341724, 1613542090);
            uint b0 = (947861580);
            uint4 r0 = uint4(0, 1, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(1919409166, 1349573078, 524526253, 341995568);
            uint b1 = (1397425408);
            uint4 r1 = uint4(1, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(495895326, 1676971657, 2131487088, 2105094094);
            uint b2 = (1515313790);
            uint4 r2 = uint4(0, 1, 1, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(1017891310, 1646044372, 1447236569, 107215658);
            uint b3 = (542666029);
            uint4 r3 = uint4(1, 3, 2, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_div_scalar_wide()
        {
            uint a0 = (1161272038);
            uint4 b0 = uint4(187325733, 1594107378, 2016183849, 1589343709);
            uint4 r0 = uint4(6, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (388768753);
            uint4 b1 = uint4(1417077283, 1773486938, 1154044032, 81831373);
            uint4 r1 = uint4(0, 0, 0, 4);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1476877645);
            uint4 b2 = uint4(653688843, 45756703, 631027637, 396671391);
            uint4 r2 = uint4(2, 32, 2, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (784365696);
            uint4 b3 = uint4(1250594097, 1818363859, 1653451772, 270557729);
            uint4 r3 = uint4(0, 0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mod_wide_wide()
        {
            uint4 a0 = uint4(146150818, 1846543305, 1071447756, 308965362);
            uint4 b0 = uint4(983050390, 771341152, 942375212, 367361754);
            uint4 r0 = uint4(146150818, 303861001, 129072544, 308965362);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(659881575, 1002365460, 861198439, 1510617532);
            uint4 b1 = uint4(749500619, 750718852, 2095151755, 88438806);
            uint4 r1 = uint4(659881575, 251646608, 861198439, 7157830);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(778525078, 1458458044, 101987897, 1249565173);
            uint4 b2 = uint4(769227442, 647214624, 1026513788, 1544950956);
            uint4 r2 = uint4(9297636, 164028796, 101987897, 1249565173);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(938026607, 1692541775, 1518877124, 1806965510);
            uint4 b3 = uint4(160166322, 1099108075, 1158422232, 1798905209);
            uint4 r3 = uint4(137194997, 593433700, 360454892, 8060301);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mod_wide_scalar()
        {
            uint4 a0 = uint4(164800505, 1062177828, 1898749675, 1701653318);
            uint b0 = (883951171);
            uint4 r0 = uint4(164800505, 178226657, 130847333, 817702147);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(820393245, 128329633, 1464010899, 896587769);
            uint b1 = (19002208);
            uint4 r1 = uint4(3298301, 14316385, 840883, 3483993);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(405208598, 959236935, 712321026, 172564850);
            uint b2 = (1982762194);
            uint4 r2 = uint4(405208598, 959236935, 712321026, 172564850);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(1540068445, 1607489717, 165478511, 647846716);
            uint b3 = (1085897743);
            uint4 r3 = uint4(454170702, 521591974, 165478511, 647846716);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_mod_scalar_wide()
        {
            uint a0 = (242383789);
            uint4 b0 = uint4(740000543, 1556450291, 1104736385, 437976569);
            uint4 r0 = uint4(242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1911837205);
            uint4 b1 = uint4(1507212038, 1906405167, 247693265, 293460573);
            uint4 r1 = uint4(404625167, 5432038, 177984350, 151073767);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1495295166);
            uint4 b2 = uint4(873323603, 530681233, 1298102643, 2057984657);
            uint4 r2 = uint4(621971563, 433932700, 197192523, 1495295166);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1000742091);
            uint4 b3 = uint4(1461372131, 1859742342, 797184687, 821888842);
            uint4 r3 = uint4(1000742091, 1000742091, 203557404, 178853249);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_plus()
        {
            uint4 a0 = uint4(1643476803, 907898539, 379615839, 1140483021);
            uint4 r0 = uint4(1643476803, 907898539, 379615839, 1140483021);
            TestUtils.AreEqual(+a0, r0);

            uint4 a1 = uint4(1735287433, 1472881565, 339091479, 401565897);
            uint4 r1 = uint4(1735287433, 1472881565, 339091479, 401565897);
            TestUtils.AreEqual(+a1, r1);

            uint4 a2 = uint4(1287765427, 174532915, 1864850812, 1566098441);
            uint4 r2 = uint4(1287765427, 174532915, 1864850812, 1566098441);
            TestUtils.AreEqual(+a2, r2);

            uint4 a3 = uint4(1145639744, 2049663954, 1723005749, 409076474);
            uint4 r3 = uint4(1145639744, 2049663954, 1723005749, 409076474);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_neg()
        {
            uint4 a0 = uint4(1955022112, 662160019, 370300775, 2141283773);
            uint4 r0 = uint4(2339945184, 3632807277, 3924666521, 2153683523);
            TestUtils.AreEqual(-a0, r0);

            uint4 a1 = uint4(1004505619, 33894270, 505708349, 1115028238);
            uint4 r1 = uint4(3290461677, 4261073026, 3789258947, 3179939058);
            TestUtils.AreEqual(-a1, r1);

            uint4 a2 = uint4(1636274969, 1542206286, 213087293, 243937487);
            uint4 r2 = uint4(2658692327, 2752761010, 4081880003, 4051029809);
            TestUtils.AreEqual(-a2, r2);

            uint4 a3 = uint4(341522275, 574159094, 1687250035, 2057919693);
            uint4 r3 = uint4(3953445021, 3720808202, 2607717261, 2237047603);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_prefix_inc()
        {
            uint4 a0 = uint4(864455342, 2035793213, 1275443862, 971919915);
            uint4 r0 = uint4(864455343, 2035793214, 1275443863, 971919916);
            TestUtils.AreEqual(++a0, r0);

            uint4 a1 = uint4(411610189, 395072276, 115573442, 913293639);
            uint4 r1 = uint4(411610190, 395072277, 115573443, 913293640);
            TestUtils.AreEqual(++a1, r1);

            uint4 a2 = uint4(432884105, 1385544935, 1835605516, 831396561);
            uint4 r2 = uint4(432884106, 1385544936, 1835605517, 831396562);
            TestUtils.AreEqual(++a2, r2);

            uint4 a3 = uint4(388229350, 1786514683, 993189311, 752093909);
            uint4 r3 = uint4(388229351, 1786514684, 993189312, 752093910);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_postfix_inc()
        {
            uint4 a0 = uint4(1751003569, 2063707595, 1500486291, 969189211);
            uint4 r0 = uint4(1751003569, 2063707595, 1500486291, 969189211);
            TestUtils.AreEqual(a0++, r0);

            uint4 a1 = uint4(1007848192, 1643023524, 1190630527, 1396179607);
            uint4 r1 = uint4(1007848192, 1643023524, 1190630527, 1396179607);
            TestUtils.AreEqual(a1++, r1);

            uint4 a2 = uint4(708474528, 1524860667, 1408994706, 375284401);
            uint4 r2 = uint4(708474528, 1524860667, 1408994706, 375284401);
            TestUtils.AreEqual(a2++, r2);

            uint4 a3 = uint4(1580130369, 717006530, 506142468, 732199129);
            uint4 r3 = uint4(1580130369, 717006530, 506142468, 732199129);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void uint4_operator_prefix_dec()
        {
            uint4 a0 = uint4(200904609, 871077500, 968578728, 638967721);
            uint4 r0 = uint4(200904608, 871077499, 968578727, 638967720);
            TestUtils.AreEqual(--a0, r0);

            uint4 a1 = uint4(1995396216, 1782514098, 1589827826, 1434377580);
            uint4 r1 = uint4(1995396215, 1782514097, 1589827825, 1434377579);
            TestUtils.AreEqual(--a1, r1);

            uint4 a2 = uint4(596759698, 1758478358, 1914114460, 71237375);
            uint4 r2 = uint4(596759697, 1758478357, 1914114459, 71237374);
            TestUtils.AreEqual(--a2, r2);

            uint4 a3 = uint4(389120307, 1310293956, 356565557, 18299409);
            uint4 r3 = uint4(389120306, 1310293955, 356565556, 18299408);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_postfix_dec()
        {
            uint4 a0 = uint4(283970262, 1109329936, 1073216143, 649439137);
            uint4 r0 = uint4(283970262, 1109329936, 1073216143, 649439137);
            TestUtils.AreEqual(a0--, r0);

            uint4 a1 = uint4(1932646215, 484207852, 524156737, 691209285);
            uint4 r1 = uint4(1932646215, 484207852, 524156737, 691209285);
            TestUtils.AreEqual(a1--, r1);

            uint4 a2 = uint4(2017728859, 377162390, 526366486, 1504625034);
            uint4 r2 = uint4(2017728859, 377162390, 526366486, 1504625034);
            TestUtils.AreEqual(a2--, r2);

            uint4 a3 = uint4(590919177, 1867810045, 2095777993, 670715645);
            uint4 r3 = uint4(590919177, 1867810045, 2095777993, 670715645);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_and_wide_wide()
        {
            uint4 a0 = uint4(779935043, 1097962163, 1939593304, 800599247);
            uint4 b0 = uint4(307705143, 1710882162, 866836769, 532490608);
            uint4 r0 = uint4(39064835, 1097961522, 864731136, 263727168);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(952140918, 782792558, 1608557706, 396446406);
            uint4 b1 = uint4(679371720, 1794035877, 1439832202, 519529812);
            uint4 r1 = uint4(675283008, 715673636, 1438646410, 379666500);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(2039894114, 1286974642, 442394124, 1759739564);
            uint4 b2 = uint4(23633139, 1209152681, 646737179, 1255867027);
            uint4 r2 = uint4(16781410, 1209017504, 34366472, 1220739712);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(233435438, 665207770, 1942050241, 1022352952);
            uint4 b3 = uint4(1900854122, 413173763, 1409138251, 2087190272);
            uint4 r3 = uint4(21541162, 10485762, 1405162561, 1013440000);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_and_wide_scalar()
        {
            uint4 a0 = uint4(443615469, 490057985, 2042441263, 1524760558);
            uint b0 = (93423598);
            uint4 r0 = uint4(1114348, 85033216, 26281518, 8488942);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(1405175110, 1941875181, 1236735839, 1365509729);
            uint b1 = (510212004);
            uint4 r1 = uint4(306251012, 304619940, 136386308, 274728480);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(428270198, 650270920, 1249238550, 814629680);
            uint b2 = (607982857);
            uint4 r2 = uint4(262144, 603983880, 3478528, 537657600);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(1862276471, 861733033, 1408932942, 957693145);
            uint b3 = (143502472);
            uint4 r3 = uint4(134218752, 852104, 8948744, 134556808);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1144543590);
            uint4 b0 = uint4(420346723, 562416448, 1393127318, 1560699552);
            uint4 r0 = uint4(547170, 18752, 1074284806, 1140867104);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (851218057);
            uint4 b1 = uint4(703880958, 1159378889, 2031211279, 1089518981);
            uint4 r1 = uint4(548671112, 1607305, 806388233, 11570305);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (270607307);
            uint4 b2 = uint4(1349288930, 520199596, 1763483957, 1248975349);
            uint4 r2 = uint4(270533570, 268501384, 8449, 2163137);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (236938635);
            uint4 b3 = uint4(185023291, 1085233038, 1845693112, 946052961);
            uint4 r3 = uint4(168239371, 1000842, 235077768, 134415617);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_or_wide_wide()
        {
            uint4 a0 = uint4(1731159103, 659068416, 382702471, 1821032196);
            uint4 b0 = uint4(1583847161, 692672727, 1161585489, 1756207130);
            uint4 r0 = uint4(2138044159, 793370327, 1476391895, 1823457054);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(1565773438, 1004000514, 948501377, 600951835);
            uint4 b1 = uint4(1321374429, 1287357212, 2075767170, 1273513430);
            uint4 r1 = uint4(1607720703, 2147473182, 2075786115, 1811533279);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(669346222, 396691477, 2108560248, 2117522137);
            uint4 b2 = uint4(1610830169, 1316929125, 511625048, 573925879);
            uint4 r2 = uint4(1743223295, 1610595957, 2147407736, 2117598207);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(330307355, 818676817, 1774459567, 1117506257);
            uint4 b3 = uint4(1502255628, 1841676448, 1682928938, 1115131952);
            uint4 r3 = uint4(1538957087, 2110637297, 1842315183, 1124063985);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_or_wide_scalar()
        {
            uint4 a0 = uint4(961259683, 471103264, 1733389229, 1591585258);
            uint b0 = (1666102508);
            uint4 r0 = uint4(2068823279, 2136930284, 1734344685, 2145369582);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(386953869, 1048929715, 1814263250, 860336789);
            uint b1 = (1148351449);
            uint4 r1 = uint4(1467118557, 2130147323, 1819506651, 2004349917);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(1637162093, 774029856, 879300408, 1179087439);
            uint b2 = (1227888278);
            uint4 r2 = uint4(1773477631, 1865602742, 2105089982, 1333229279);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(797240690, 46921989, 1980838747, 284225881);
            uint b3 = (1977614655);
            uint4 r3 = uint4(2145709439, 2011953471, 2012296063, 1978724735);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1213433101);
            uint4 b0 = uint4(1212928242, 1614462616, 936937728, 764766995);
            uint4 r0 = uint4(1213978111, 1752940445, 2145094925, 1842867999);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (306352095);
            uint4 b1 = uint4(574719481, 1283571271, 2109131012, 979469710);
            uint4 r1 = uint4(843288575, 1589886943, 2146881503, 979603423);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1348323481);
            uint4 b2 = uint4(1407542578, 697517649, 1059093741, 627815046);
            uint4 r2 = uint4(1409150395, 2044710617, 2138963197, 1971321503);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (418822515);
            uint4 b3 = uint4(83214352, 424663473, 447949225, 527022375);
            uint4 r3 = uint4(486013299, 436206067, 452442619, 536852855);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_xor_wide_wide()
        {
            uint4 a0 = uint4(1556324760, 207002929, 1843444873, 1632079131);
            uint4 b0 = uint4(1054997548, 1523759632, 251164872, 110472397);
            uint4 r0 = uint4(1646419380, 1451501345, 1662567489, 1741824470);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(1460334334, 1607815585, 220623650, 38668553);
            uint4 b1 = uint4(384031112, 1109163205, 535118981, 179106262);
            uint4 r1 = uint4(1105803126, 499723620, 314783655, 149092575);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(47193340, 643663548, 1371932564, 94957188);
            uint4 b2 = uint4(1523031711, 1713313372, 1294118730, 520360641);
            uint4 r2 = uint4(1477935715, 1078104288, 484747486, 447544389);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(700973621, 370621508, 2087573076, 351476570);
            uint4 b3 = uint4(1040688781, 1020757245, 1143954843, 1281933464);
            uint4 r3 = uint4(399484088, 717273273, 943885263, 1486609346);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_xor_wide_scalar()
        {
            uint4 a0 = uint4(2124666952, 177397845, 574879617, 1937385541);
            uint b0 = (493665894);
            uint4 r0 = uint4(1674536494, 402546227, 1060063719, 1846973987);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(1136545648, 535061373, 289301586, 1305234431);
            uint b1 = (213863690);
            uint4 r1 = uint4(1325466234, 324742775, 495003992, 1098057461);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(353786540, 1267729267, 125659640, 1315625690);
            uint b2 = (1308626970);
            uint4 r2 = uint4(1528187574, 93328233, 1232959970, 6998720);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(1730088797, 375757978, 491079274, 191750702);
            uint b3 = (116862046);
            uint4 r3 = uint4(1642603267, 278048964, 464677428, 228249200);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1288453276);
            uint4 b0 = uint4(1077599928, 884741329, 212164516, 1585020328);
            uint4 r0 = uint4(217506340, 2020616269, 1080648504, 313868596);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (152985454);
            uint4 b1 = uint4(1775851275, 1416249064, 1309317737, 1773918217);
            uint4 r1 = uint4(1623656549, 1567908230, 1192543495, 1621460839);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1509843030);
            uint4 b2 = uint4(1206045972, 1154916424, 1947871003, 1774252400);
            uint4 r2 = uint4(505195842, 489209886, 769935181, 809406758);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1946113778);
            uint4 b3 = uint4(1079717492, 290620937, 1382343363, 939045099);
            uint4 r3 = uint4(866416774, 1655558395, 563852337, 1141368345);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_left_shift()
        {
            uint4 a0 = uint4(197771193, 622182602, 1283988958, 1327917304);
            int b0 = (1321149625);
            uint4 r0 = uint4(1912602624, 2483027968, 3154116608, 4026531840);
            TestUtils.AreEqual(a0 << b0, r0);

            uint4 a1 = uint4(473415985, 870301196, 2058433484, 1200694230);
            int b1 = (432425717);
            uint4 r1 = uint4(639631360, 3246391296, 2038431744, 2059403264);
            TestUtils.AreEqual(a1 << b1, r1);

            uint4 a2 = uint4(1531607705, 1008296534, 1447702302, 1079614371);
            int b2 = (1360008038);
            uint4 r2 = uint4(3533612608, 106468736, 2458634112, 375843008);
            TestUtils.AreEqual(a2 << b2, r2);

            uint4 a3 = uint4(35667343, 2045594989, 2077023268, 592678686);
            int b3 = (1664454606);
            uint4 r3 = uint4(258195456, 1398489088, 923336704, 3821502464);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_right_shift()
        {
            uint4 a0 = uint4(548167301, 1161338299, 1617625829, 1860731847);
            int b0 = (1266801540);
            uint4 r0 = uint4(34260456, 72583643, 101101614, 116295740);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint4 a1 = uint4(713958715, 770466193, 1265099998, 572763124);
            int b1 = (196552656);
            uint4 r1 = uint4(10894, 11756, 19303, 8739);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint4 a2 = uint4(506619530, 2031319045, 701927980, 917785020);
            int b2 = (426807581);
            uint4 r2 = uint4(0, 3, 1, 1);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint4 a3 = uint4(569504877, 1102123711, 334005460, 1624751550);
            int b3 = (185593382);
            uint4 r3 = uint4(8898513, 17220682, 5218835, 25386742);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void uint4_operator_bitwise_not()
        {
            uint4 a0 = uint4(1403358969, 831360921, 2088190243, 976721016);
            uint4 r0 = uint4(2891608326, 3463606374, 2206777052, 3318246279);
            TestUtils.AreEqual(~a0, r0);

            uint4 a1 = uint4(878283189, 1935567517, 1420884856, 472965491);
            uint4 r1 = uint4(3416684106, 2359399778, 2874082439, 3822001804);
            TestUtils.AreEqual(~a1, r1);

            uint4 a2 = uint4(771711426, 2061524024, 753208488, 2097179283);
            uint4 r2 = uint4(3523255869, 2233443271, 3541758807, 2197788012);
            TestUtils.AreEqual(~a2, r2);

            uint4 a3 = uint4(1303022493, 1289372466, 1635981125, 1951018596);
            uint4 r3 = uint4(2991944802, 3005594829, 2658986170, 2343948699);
            TestUtils.AreEqual(~a3, r3);
        }

        [TestCompiler]
        public static void uint4_shuffle_result_1()
        {
            uint4 a = uint4(0, 1, 2, 3);
            uint4 b = uint4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW), (7));
        }

        [TestCompiler]
        public static void uint4_shuffle_result_2()
        {
            uint4 a = uint4(0, 1, 2, 3);
            uint4 b = uint4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), uint2(5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX), uint2(6, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint2(1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftW), uint2(7, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftZ), uint2(7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), uint2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW), uint2(5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), uint2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightW), uint2(6, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ), uint2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), uint2(6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), uint2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), uint2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightY), uint2(7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), uint2(4, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW), uint2(1, 3));
        }

        [TestCompiler]
        public static void uint4_shuffle_result_3()
        {
            uint4 a = uint4(0, 1, 2, 3);
            uint4 b = uint4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightY), uint3(2, 7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.LeftW), uint3(6, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightX), uint3(2, 7, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), uint3(5, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), uint3(7, 6, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint3(3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightX), uint3(3, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightW), uint3(3, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.RightZ), uint3(6, 5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), uint3(5, 4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightW, ShuffleComponent.LeftX), uint3(7, 7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint3(6, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightW), uint3(6, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightY), uint3(3, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint3(6, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightW), uint3(5, 1, 7));
        }

        [TestCompiler]
        public static void uint4_shuffle_result_4()
        {
            uint4 a = uint4(0, 1, 2, 3);
            uint4 b = uint4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ), uint4(1, 3, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightZ), uint4(5, 3, 6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.RightW, ShuffleComponent.LeftZ), uint4(6, 6, 7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ), uint4(4, 5, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), uint4(6, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightW), uint4(4, 5, 5, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightW, ShuffleComponent.LeftX, ShuffleComponent.RightW), uint4(1, 7, 0, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftX), uint4(5, 0, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightW, ShuffleComponent.LeftW, ShuffleComponent.LeftY), uint4(4, 7, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint4(5, 4, 1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), uint4(0, 2, 6, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightW, ShuffleComponent.RightW), uint4(2, 5, 7, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ, ShuffleComponent.RightX), uint4(3, 4, 2, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), uint4(4, 0, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(6, 4, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint4(3, 7, 1, 5));
        }


    }
}
