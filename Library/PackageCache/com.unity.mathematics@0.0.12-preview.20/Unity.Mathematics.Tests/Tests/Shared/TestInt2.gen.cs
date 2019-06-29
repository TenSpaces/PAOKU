// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2
    {
        [TestCompiler]
        public static void int2_zero()
        {
            TestUtils.AreEqual(int2.zero.x, 0);
            TestUtils.AreEqual(int2.zero.y, 0);
        }

        [TestCompiler]
        public static void int2_constructor()
        {
            int2 a = new int2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void int2_scalar_constructor()
        {
            int2 a = new int2(17);
            TestUtils.AreEqual(a.x, 17);
            TestUtils.AreEqual(a.y, 17);
        }

        [TestCompiler]
        public static void int2_static_constructor()
        {
            int2 a = int2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void int2_static_scalar_constructor()
        {
            int2 a = int2(17);
            TestUtils.AreEqual(a.x, 17);
            TestUtils.AreEqual(a.y, 17);
        }

        [TestCompiler]
        public static void int2_operator_equal_wide_wide()
        {
            int2 a0 = int2(790229414, 970783976);
            int2 b0 = int2(612337669, 1214209108);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(1428432738, 1578747135);
            int2 b1 = int2(2120643427, 295461214);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(1733797753, 2001507228);
            int2 b2 = int2(1510890331, 1893316566);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(1446876437, 1777406370);
            int2 b3 = int2(921816149, 1834958575);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_equal_wide_scalar()
        {
            int2 a0 = int2(1211464300, 1921862607);
            int b0 = (746972502);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(508076684, 1394594555);
            int b1 = (1249127920);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(746862310, 1884008277);
            int b2 = (1733655277);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(1682018538, 936027116);
            int b3 = (795585660);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_equal_scalar_wide()
        {
            int a0 = (1150044438);
            int2 b0 = int2(233855098, 924242519);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1402948791);
            int2 b1 = int2(601381975, 2120518068);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (629187703);
            int2 b2 = int2(1971977031, 47183124);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1061805787);
            int2 b3 = int2(1009011238, 312511148);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_not_equal_wide_wide()
        {
            int2 a0 = int2(1660932106, 982847023);
            int2 b0 = int2(107139049, 75478496);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(97046264, 1739517447);
            int2 b1 = int2(2055495054, 358586687);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(1253499180, 1830584069);
            int2 b2 = int2(942338347, 111564990);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(1841470429, 1397841646);
            int2 b3 = int2(113811950, 948912488);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_not_equal_wide_scalar()
        {
            int2 a0 = int2(747758183, 1033001286);
            int b0 = (248693828);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(1439973882, 1197845089);
            int b1 = (2138928797);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(1432672459, 238704450);
            int b2 = (950170763);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(2105962247, 1640688041);
            int b3 = (727205263);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_not_equal_scalar_wide()
        {
            int a0 = (2076921066);
            int2 b0 = int2(2037494727, 1989050616);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (48833929);
            int2 b1 = int2(1897435904, 514354517);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1783749164);
            int2 b2 = int2(364694471, 754315072);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (124108032);
            int2 b3 = int2(1512967900, 1178825850);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_wide_wide()
        {
            int2 a0 = int2(1182186063, 415538999);
            int2 b0 = int2(524633529, 1032195686);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(1667335818, 1566618442);
            int2 b1 = int2(760723389, 1505751409);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1166180837, 639095188);
            int2 b2 = int2(431962172, 1287906509);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(1080836365, 771119973);
            int2 b3 = int2(1560084663, 1450178202);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_wide_scalar()
        {
            int2 a0 = int2(608447185, 818840405);
            int b0 = (1491216667);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(869219329, 1214500548);
            int b1 = (2080125385);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1361741203, 1615392341);
            int b2 = (1667165786);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(840091491, 1247103789);
            int b3 = (469591900);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_scalar_wide()
        {
            int a0 = (548436837);
            int2 b0 = int2(282703327, 14370648);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1862117300);
            int2 b1 = int2(1304793311, 826073259);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (988910157);
            int2 b2 = int2(445132446, 1139670255);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (111349251);
            int2 b3 = int2(1102440676, 112183144);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_wide_wide()
        {
            int2 a0 = int2(592884447, 2133928932);
            int2 b0 = int2(138737040, 192863971);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(918957182, 1284069471);
            int2 b1 = int2(1700841444, 1044631301);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(194584707, 739120780);
            int2 b2 = int2(1391589821, 730837695);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(241654068, 1340158550);
            int2 b3 = int2(253553987, 2078872742);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_wide_scalar()
        {
            int2 a0 = int2(1097138316, 211763648);
            int b0 = (438688675);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(1883002501, 43662641);
            int b1 = (56406996);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(1923456111, 1219010035);
            int b2 = (1437755186);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(2125058448, 893125636);
            int b3 = (304028799);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_scalar_wide()
        {
            int a0 = (2024896938);
            int2 b0 = int2(599356784, 185671342);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1932327391);
            int2 b1 = int2(2025591013, 1257191721);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1312388500);
            int2 b2 = int2(1443698859, 779217735);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (691047512);
            int2 b3 = int2(741776730, 732565983);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_equal_wide_wide()
        {
            int2 a0 = int2(1577248162, 2043073061);
            int2 b0 = int2(903445031, 2108974565);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(1688380407, 176431985);
            int2 b1 = int2(210822256, 1281704747);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(223299035, 1502802140);
            int2 b2 = int2(453681718, 66138830);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(1691709825, 386789394);
            int2 b3 = int2(1229799377, 1620922595);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_equal_wide_scalar()
        {
            int2 a0 = int2(1722165358, 1219858357);
            int b0 = (1688048545);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(860410743, 348104022);
            int b1 = (411099660);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(1963256951, 58924407);
            int b2 = (212084836);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(1459242706, 532949158);
            int b3 = (1745758438);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_less_equal_scalar_wide()
        {
            int a0 = (1777585);
            int2 b0 = int2(1181030049, 1787703989);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1729760948);
            int2 b1 = int2(1816537388, 1359786460);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (874999193);
            int2 b2 = int2(1678863148, 1711365839);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (762067160);
            int2 b3 = int2(11953554, 1131583906);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_equal_wide_wide()
        {
            int2 a0 = int2(263000030, 744235661);
            int2 b0 = int2(1395535146, 1178373944);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(1893760267, 237248);
            int2 b1 = int2(1237373760, 1364855321);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(1062370984, 1676977687);
            int2 b2 = int2(600811864, 362060472);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(816766880, 1089431546);
            int2 b3 = int2(290870624, 1839067862);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_equal_wide_scalar()
        {
            int2 a0 = int2(2112791350, 1043657935);
            int b0 = (1470533736);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(101764761, 556026890);
            int b1 = (1529909067);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(281734132, 815093894);
            int b2 = (1186600258);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(609211196, 829548642);
            int b3 = (1604309397);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_greater_equal_scalar_wide()
        {
            int a0 = (1525542481);
            int2 b0 = int2(1503244746, 861711266);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (817773856);
            int2 b1 = int2(925984572, 571221723);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (683686810);
            int2 b2 = int2(118252990, 1653952090);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1240253990);
            int2 b3 = int2(1947039008, 1869136019);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_add_wide_wide()
        {
            int2 a0 = int2(2049228671, 1658660009);
            int2 b0 = int2(2088751567, 645762023);
            int2 r0 = int2(-156987058, -1990545264);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(491719392, 937013355);
            int2 b1 = int2(306868786, 4360271);
            int2 r1 = int2(798588178, 941373626);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(81108663, 1063894558);
            int2 b2 = int2(506047997, 2094559874);
            int2 r2 = int2(587156660, -1136512864);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(86954702, 843159721);
            int2 b3 = int2(1634712736, 1601474440);
            int2 r3 = int2(1721667438, -1850333135);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_add_wide_scalar()
        {
            int2 a0 = int2(2038218457, 134923711);
            int b0 = (2124409227);
            int2 r0 = int2(-132339612, -2035634358);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(875689667, 997710928);
            int b1 = (1338884463);
            int2 r1 = int2(-2080393166, -1958371905);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(340490871, 70433301);
            int b2 = (1067888129);
            int2 r2 = int2(1408379000, 1138321430);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(2003021861, 1160398286);
            int b3 = (1635971971);
            int2 r3 = int2(-655973464, -1498597039);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_add_scalar_wide()
        {
            int a0 = (391092078);
            int2 b0 = int2(519908870, 851424292);
            int2 r0 = int2(911000948, 1242516370);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (328314822);
            int2 b1 = int2(135622204, 740923360);
            int2 r1 = int2(463937026, 1069238182);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (655394201);
            int2 b2 = int2(1451896269, 1781697072);
            int2 r2 = int2(2107290470, -1857876023);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (996031825);
            int2 b3 = int2(1557774949, 779774940);
            int2 r3 = int2(-1741160522, 1775806765);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_sub_wide_wide()
        {
            int2 a0 = int2(1353441118, 797269833);
            int2 b0 = int2(1332656812, 1827794007);
            int2 r0 = int2(20784306, -1030524174);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(659988112, 56022121);
            int2 b1 = int2(972557431, 2078233689);
            int2 r1 = int2(-312569319, -2022211568);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(365847472, 2062899435);
            int2 b2 = int2(1508184327, 1372307701);
            int2 r2 = int2(-1142336855, 690591734);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(1380988474, 799885138);
            int2 b3 = int2(810327977, 936799885);
            int2 r3 = int2(570660497, -136914747);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_sub_wide_scalar()
        {
            int2 a0 = int2(1176369558, 1934521195);
            int b0 = (462232403);
            int2 r0 = int2(714137155, 1472288792);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(309452150, 108910717);
            int b1 = (1417634074);
            int2 r1 = int2(-1108181924, -1308723357);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(1306356714, 1451794815);
            int b2 = (1502312334);
            int2 r2 = int2(-195955620, -50517519);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(281174200, 1913724431);
            int b3 = (87530840);
            int2 r3 = int2(193643360, 1826193591);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_sub_scalar_wide()
        {
            int a0 = (1691534405);
            int2 b0 = int2(2022393810, 1612688515);
            int2 r0 = int2(-330859405, 78845890);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (496689713);
            int2 b1 = int2(887037586, 2097630964);
            int2 r1 = int2(-390347873, -1600941251);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (374934538);
            int2 b2 = int2(939035482, 935242277);
            int2 r2 = int2(-564100944, -560307739);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1789300421);
            int2 b3 = int2(264712893, 1231856067);
            int2 r3 = int2(1524587528, 557444354);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mul_wide_wide()
        {
            int2 a0 = int2(245827027, 208934650);
            int2 b0 = int2(759663997, 350129201);
            int2 r0 = int2(-632811769, 1402281434);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(1019478917, 568231809);
            int2 b1 = int2(477450108, 1635735015);
            int2 r1 = int2(332447596, -1932977561);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(877289039, 1585782440);
            int2 b2 = int2(388710278, 757722665);
            int2 r2 = int2(-1670918566, 1455036648);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(2111178729, 1186019069);
            int2 b3 = int2(1509388321, 1841703980);
            int2 r3 = int2(2128344329, -594088068);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mul_wide_scalar()
        {
            int2 a0 = int2(1762033447, 465343930);
            int b0 = (1476837906);
            int2 r0 = int2(-1313177922, 1326807828);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(1570757881, 1824319147);
            int b1 = (1326409563);
            int2 r1 = int2(1666366339, -252064823);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(1356578909, 154616909);
            int b2 = (72749215);
            int2 r2 = int2(130042307, 1400257491);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(975743632, 1958912969);
            int b3 = (573770299);
            int2 r3 = int2(414773040, -699623085);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mul_scalar_wide()
        {
            int a0 = (99541948);
            int2 b0 = int2(1764461774, 657072478);
            int2 r0 = int2(-950398648, -102049016);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (1459784358);
            int2 b1 = int2(1610646683, 1632058826);
            int2 r1 = int2(1040681602, -1659570948);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (868441654);
            int2 b2 = int2(1408757883, 335917146);
            int2 r2 = int2(1867178994, -1836957956);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (2105124483);
            int2 b3 = int2(1178393968, 1963904348);
            int2 r3 = int2(-1028919216, 2084093460);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_div_wide_wide()
        {
            int2 a0 = int2(1590198532, 507812502);
            int2 b0 = int2(1434703236, 911965201);
            int2 r0 = int2(1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(126627032, 1058247011);
            int2 b1 = int2(390415521, 128746927);
            int2 r1 = int2(0, 8);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(427387861, 290676154);
            int2 b2 = int2(525835375, 816946613);
            int2 r2 = int2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(1829594484, 1127868739);
            int2 b3 = int2(878264647, 146789678);
            int2 r3 = int2(2, 7);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_div_wide_scalar()
        {
            int2 a0 = int2(560951562, 1218680769);
            int b0 = (947861580);
            int2 r0 = int2(0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(375341724, 1919409166);
            int b1 = (1613542090);
            int2 r1 = int2(0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(1397425408, 524526253);
            int b2 = (1349573078);
            int2 r2 = int2(1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(341995568, 1515313790);
            int b3 = (495895326);
            int2 r3 = int2(0, 3);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_div_scalar_wide()
        {
            int a0 = (1161272038);
            int2 b0 = int2(187325733, 1594107378);
            int2 r0 = int2(6, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (2016183849);
            int2 b1 = int2(1589343709, 388768753);
            int2 r1 = int2(1, 5);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1417077283);
            int2 b2 = int2(1773486938, 1154044032);
            int2 r2 = int2(0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (81831373);
            int2 b3 = int2(1476877645, 653688843);
            int2 r3 = int2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mod_wide_wide()
        {
            int2 a0 = int2(146150818, 1846543305);
            int2 b0 = int2(983050390, 771341152);
            int2 r0 = int2(146150818, 303861001);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(1071447756, 308965362);
            int2 b1 = int2(942375212, 367361754);
            int2 r1 = int2(129072544, 308965362);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(659881575, 1002365460);
            int2 b2 = int2(749500619, 750718852);
            int2 r2 = int2(659881575, 251646608);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(861198439, 1510617532);
            int2 b3 = int2(2095151755, 88438806);
            int2 r3 = int2(861198439, 7157830);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mod_wide_scalar()
        {
            int2 a0 = int2(164800505, 1062177828);
            int b0 = (883951171);
            int2 r0 = int2(164800505, 178226657);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(1898749675, 820393245);
            int b1 = (1701653318);
            int2 r1 = int2(197096357, 820393245);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(19002208, 1464010899);
            int b2 = (128329633);
            int2 r2 = int2(19002208, 52384936);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(896587769, 1982762194);
            int b3 = (405208598);
            int2 r3 = int2(86170573, 361927802);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_mod_scalar_wide()
        {
            int a0 = (242383789);
            int2 b0 = int2(740000543, 1556450291);
            int2 r0 = int2(242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1104736385);
            int2 b1 = int2(437976569, 1911837205);
            int2 r1 = int2(228783247, 1104736385);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1507212038);
            int2 b2 = int2(1906405167, 247693265);
            int2 r2 = int2(1507212038, 21052448);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (293460573);
            int2 b3 = int2(1495295166, 873323603);
            int2 r3 = int2(293460573, 293460573);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_plus()
        {
            int2 a0 = int2(1643476803, 907898539);
            int2 r0 = int2(1643476803, 907898539);
            TestUtils.AreEqual(+a0, r0);

            int2 a1 = int2(379615839, 1735287433);
            int2 r1 = int2(379615839, 1735287433);
            TestUtils.AreEqual(+a1, r1);

            int2 a2 = int2(1743199272, 339091479);
            int2 r2 = int2(1743199272, 339091479);
            TestUtils.AreEqual(+a2, r2);

            int2 a3 = int2(401565897, 849339193);
            int2 r3 = int2(401565897, 849339193);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void int2_operator_neg()
        {
            int2 a0 = int2(1955022112, 662160019);
            int2 r0 = int2(-1955022112, -662160019);
            TestUtils.AreEqual(-a0, r0);

            int2 a1 = int2(370300775, 1004505619);
            int2 r1 = int2(-370300775, -1004505619);
            TestUtils.AreEqual(-a1, r1);

            int2 a2 = int2(28153593, 505708349);
            int2 r2 = int2(-28153593, -505708349);
            TestUtils.AreEqual(-a2, r2);

            int2 a3 = int2(1115028238, 694995093);
            int2 r3 = int2(-1115028238, -694995093);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void int2_operator_prefix_inc()
        {
            int2 a0 = int2(864455342, 2035793213);
            int2 r0 = int2(864455343, 2035793214);
            TestUtils.AreEqual(++a0, r0);

            int2 a1 = int2(1275443862, 411610189);
            int2 r1 = int2(1275443863, 411610190);
            TestUtils.AreEqual(++a1, r1);

            int2 a2 = int2(446210725, 115573442);
            int2 r2 = int2(446210726, 115573443);
            TestUtils.AreEqual(++a2, r2);

            int2 a3 = int2(913293639, 1208161871);
            int2 r3 = int2(913293640, 1208161872);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void int2_operator_postfix_inc()
        {
            int2 a0 = int2(1751003569, 2063707595);
            int2 r0 = int2(1751003569, 2063707595);
            TestUtils.AreEqual(a0++, r0);

            int2 a1 = int2(1500486291, 1007848192);
            int2 r1 = int2(1500486291, 1007848192);
            TestUtils.AreEqual(a1++, r1);

            int2 a2 = int2(2028651936, 1190630527);
            int2 r2 = int2(2028651936, 1190630527);
            TestUtils.AreEqual(a2++, r2);

            int2 a3 = int2(1396179607, 177416855);
            int2 r3 = int2(1396179607, 177416855);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void int2_operator_prefix_dec()
        {
            int2 a0 = int2(200904609, 871077500);
            int2 r0 = int2(200904608, 871077499);
            TestUtils.AreEqual(--a0, r0);

            int2 a1 = int2(968578728, 1995396216);
            int2 r1 = int2(968578727, 1995396215);
            TestUtils.AreEqual(--a1, r1);

            int2 a2 = int2(435367037, 1589827826);
            int2 r2 = int2(435367036, 1589827825);
            TestUtils.AreEqual(--a2, r2);

            int2 a3 = int2(1434377580, 1699290403);
            int2 r3 = int2(1434377579, 1699290402);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void int2_operator_postfix_dec()
        {
            int2 a0 = int2(283970262, 1109329936);
            int2 r0 = int2(283970262, 1109329936);
            TestUtils.AreEqual(a0--, r0);

            int2 a1 = int2(1073216143, 1932646215);
            int2 r1 = int2(1073216143, 1932646215);
            TestUtils.AreEqual(a1--, r1);

            int2 a2 = int2(1174104498, 524156737);
            int2 r2 = int2(1174104498, 524156737);
            TestUtils.AreEqual(a2--, r2);

            int2 a3 = int2(691209285, 802721301);
            int2 r3 = int2(691209285, 802721301);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_and_wide_wide()
        {
            int2 a0 = int2(779935043, 1097962163);
            int2 b0 = int2(307705143, 1710882162);
            int2 r0 = int2(39064835, 1097961522);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(1939593304, 800599247);
            int2 b1 = int2(866836769, 532490608);
            int2 r1 = int2(864731136, 263727168);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(952140918, 782792558);
            int2 b2 = int2(679371720, 1794035877);
            int2 r2 = int2(675283008, 715673636);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(1608557706, 396446406);
            int2 b3 = int2(1439832202, 519529812);
            int2 r3 = int2(1438646410, 379666500);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_and_wide_scalar()
        {
            int2 a0 = int2(443615469, 490057985);
            int b0 = (93423598);
            int2 r0 = int2(1114348, 85033216);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(2042441263, 1405175110);
            int b1 = (1524760558);
            int2 r1 = int2(1486958126, 1388397894);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(510212004, 1236735839);
            int b2 = (1941875181);
            int2 r2 = int2(304619940, 1102446925);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(1365509729, 607982857);
            int b3 = (428270198);
            int2 r3 = int2(285475424, 262144);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1144543590);
            int2 b0 = int2(420346723, 562416448);
            int2 r0 = int2(547170, 18752);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1393127318);
            int2 b1 = int2(1560699552, 851218057);
            int2 r1 = int2(1358979712, 302517888);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (703880958);
            int2 b2 = int2(1159378889, 2031211279);
            int2 r2 = int2(17831624, 688935438);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1089518981);
            int2 b3 = int2(270607307, 1349288930);
            int2 r3 = int2(2105729, 1080066432);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_or_wide_wide()
        {
            int2 a0 = int2(1731159103, 659068416);
            int2 b0 = int2(1583847161, 692672727);
            int2 r0 = int2(2138044159, 793370327);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(382702471, 1821032196);
            int2 b1 = int2(1161585489, 1756207130);
            int2 r1 = int2(1476391895, 1823457054);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(1565773438, 1004000514);
            int2 b2 = int2(1321374429, 1287357212);
            int2 r2 = int2(1607720703, 2147473182);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(948501377, 600951835);
            int2 b3 = int2(2075767170, 1273513430);
            int2 r3 = int2(2075786115, 1811533279);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_or_wide_scalar()
        {
            int2 a0 = int2(961259683, 471103264);
            int b0 = (1666102508);
            int2 r0 = int2(2068823279, 2136930284);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(1733389229, 386953869);
            int b1 = (1591585258);
            int2 r1 = int2(2145250287, 1608383471);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(1148351449, 1814263250);
            int b2 = (1048929715);
            int2 r2 = int2(2130147323, 2124903923);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(860336789, 1227888278);
            int b3 = (1637162093);
            int2 r3 = int2(1943518973, 1773477631);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1213433101);
            int2 b0 = int2(1212928242, 1614462616);
            int2 r0 = int2(1213978111, 1752940445);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (936937728);
            int2 b1 = int2(764766995, 306352095);
            int2 r1 = int2(1071508243, 937070559);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (574719481);
            int2 b2 = int2(1283571271, 2109131012);
            int2 r2 = int2(1858191359, 2146946557);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (979469710);
            int2 b3 = int2(1348323481, 1407542578);
            int2 r3 = int2(2055064991, 2078664126);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_xor_wide_wide()
        {
            int2 a0 = int2(1556324760, 207002929);
            int2 b0 = int2(1054997548, 1523759632);
            int2 r0 = int2(1646419380, 1451501345);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(1843444873, 1632079131);
            int2 b1 = int2(251164872, 110472397);
            int2 r1 = int2(1662567489, 1741824470);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(1460334334, 1607815585);
            int2 b2 = int2(384031112, 1109163205);
            int2 r2 = int2(1105803126, 499723620);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(220623650, 38668553);
            int2 b3 = int2(535118981, 179106262);
            int2 r3 = int2(314783655, 149092575);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_xor_wide_scalar()
        {
            int2 a0 = int2(2124666952, 177397845);
            int b0 = (493665894);
            int2 r0 = int2(1674536494, 402546227);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(574879617, 1136545648);
            int b1 = (1937385541);
            int2 r1 = int2(1362747332, 818177845);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(213863690, 289301586);
            int b2 = (535061373);
            int2 r2 = int2(324742775, 249169711);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(1305234431, 1308626970);
            int b3 = (353786540);
            int2 r3 = int2(1490686291, 1528187574);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1288453276);
            int2 b0 = int2(1077599928, 884741329);
            int2 r0 = int2(217506340, 2020616269);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (212164516);
            int2 b1 = int2(1585020328, 152985454);
            int2 r1 = int2(1390158348, 96141514);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1775851275);
            int2 b2 = int2(1416249064, 1309317737);
            int2 r2 = int2(1035168227, 668192098);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (1773918217);
            int2 b3 = int2(1509843030, 1206045972);
            int2 r3 = int2(809875551, 777590045);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_left_shift()
        {
            int2 a0 = int2(197771193, 622182602);
            int b0 = (1321149625);
            int2 r0 = int2(1912602624, -1811939328);
            TestUtils.AreEqual(a0 << b0, r0);

            int2 a1 = int2(1283988958, 473415985);
            int b1 = (1327917304);
            int2 r1 = int2(-570425344, 822083584);
            TestUtils.AreEqual(a1 << b1, r1);

            int2 a2 = int2(432425717, 2058433484);
            int b2 = (870301196);
            int2 r2 = int2(1689210880, 322748416);
            TestUtils.AreEqual(a2 << b2, r2);

            int2 a3 = int2(1200694230, 1360008038);
            int b3 = (1531607705);
            int2 r3 = int2(-1409286144, -872415232);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_right_shift()
        {
            int2 a0 = int2(548167301, 1161338299);
            int b0 = (1266801540);
            int2 r0 = int2(34260456, 72583643);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2 a1 = int2(1617625829, 713958715);
            int b1 = (1860731847);
            int2 r1 = int2(12637701, 5577802);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2 a2 = int2(196552656, 1265099998);
            int b2 = (770466193);
            int2 r2 = int2(1499, 9651);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2 a3 = int2(572763124, 426807581);
            int b3 = (506619530);
            int2 r3 = int2(559338, 416804);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void int2_operator_bitwise_not()
        {
            int2 a0 = int2(1403358969, 831360921);
            int2 r0 = int2(-1403358970, -831360922);
            TestUtils.AreEqual(~a0, r0);

            int2 a1 = int2(2088190243, 878283189);
            int2 r1 = int2(-2088190244, -878283190);
            TestUtils.AreEqual(~a1, r1);

            int2 a2 = int2(308994339, 1420884856);
            int2 r2 = int2(-308994340, -1420884857);
            TestUtils.AreEqual(~a2, r2);

            int2 a3 = int2(472965491, 627580960);
            int2 r3 = int2(-472965492, -627580961);
            TestUtils.AreEqual(~a3, r3);
        }

        [TestCompiler]
        public static void int2_shuffle_result_1()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public static void int2_shuffle_result_2()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), int2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), int2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), int2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), int2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), int2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), int2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), int2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), int2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), int2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), int2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), int2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), int2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), int2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), int2(3, 3));
        }

        [TestCompiler]
        public static void int2_shuffle_result_3()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), int3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), int3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), int3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), int3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), int3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), int3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), int3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), int3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), int3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int3(3, 1, 1));
        }

        [TestCompiler]
        public static void int2_shuffle_result_4()
        {
            int2 a = int2(0, 1);
            int2 b = int2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), int4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), int4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), int4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), int4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), int4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), int4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), int4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), int4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), int4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), int4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), int4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), int4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), int4(2, 0, 0, 0));
        }


    }
}
