// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt4x4
    {
        [TestCompiler]
        public static void int4x4_zero()
        {
            TestUtils.AreEqual(int4x4.zero.c0.x, 0);
            TestUtils.AreEqual(int4x4.zero.c0.y, 0);
            TestUtils.AreEqual(int4x4.zero.c0.z, 0);
            TestUtils.AreEqual(int4x4.zero.c0.w, 0);
            TestUtils.AreEqual(int4x4.zero.c1.x, 0);
            TestUtils.AreEqual(int4x4.zero.c1.y, 0);
            TestUtils.AreEqual(int4x4.zero.c1.z, 0);
            TestUtils.AreEqual(int4x4.zero.c1.w, 0);
            TestUtils.AreEqual(int4x4.zero.c2.x, 0);
            TestUtils.AreEqual(int4x4.zero.c2.y, 0);
            TestUtils.AreEqual(int4x4.zero.c2.z, 0);
            TestUtils.AreEqual(int4x4.zero.c2.w, 0);
            TestUtils.AreEqual(int4x4.zero.c3.x, 0);
            TestUtils.AreEqual(int4x4.zero.c3.y, 0);
            TestUtils.AreEqual(int4x4.zero.c3.z, 0);
            TestUtils.AreEqual(int4x4.zero.c3.w, 0);
        }

        [TestCompiler]
        public static void int4x4_identity()
        {
            TestUtils.AreEqual(int4x4.identity.c0.x, 1);
            TestUtils.AreEqual(int4x4.identity.c0.y, 0);
            TestUtils.AreEqual(int4x4.identity.c0.z, 0);
            TestUtils.AreEqual(int4x4.identity.c0.w, 0);
            TestUtils.AreEqual(int4x4.identity.c1.x, 0);
            TestUtils.AreEqual(int4x4.identity.c1.y, 1);
            TestUtils.AreEqual(int4x4.identity.c1.z, 0);
            TestUtils.AreEqual(int4x4.identity.c1.w, 0);
            TestUtils.AreEqual(int4x4.identity.c2.x, 0);
            TestUtils.AreEqual(int4x4.identity.c2.y, 0);
            TestUtils.AreEqual(int4x4.identity.c2.z, 1);
            TestUtils.AreEqual(int4x4.identity.c2.w, 0);
            TestUtils.AreEqual(int4x4.identity.c3.x, 0);
            TestUtils.AreEqual(int4x4.identity.c3.y, 0);
            TestUtils.AreEqual(int4x4.identity.c3.z, 0);
            TestUtils.AreEqual(int4x4.identity.c3.w, 1);
        }

        [TestCompiler]
        public static void int4x4_operator_equal_wide_wide()
        {
            int4x4 a0 = int4x4(790229414, 970783976, 1428432738, 1578747135, 1733797753, 2001507228, 1446876437, 1777406370, 1426387268, 1809275021, 1843770816, 1172185222, 1469608940, 869874758, 458603090, 581282460);
            int4x4 b0 = int4x4(612337669, 1214209108, 2120643427, 295461214, 1510890331, 1893316566, 921816149, 1834958575, 1482011863, 2062852792, 226398742, 770290735, 36812057, 543224481, 1565350150, 1909926604);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(1948324909, 1129078206, 1638391029, 1135553683, 2079295200, 576232476, 608208235, 11172509, 1025529486, 2095601864, 193500113, 1780908384, 1587636094, 1892083815, 1250768669, 1984341771);
            int4x4 b1 = int4x4(1619900436, 1849990483, 1261604411, 161864811, 843379453, 1780425458, 215681636, 2123130580, 708665810, 1902328998, 1808456602, 563830672, 200493241, 1391620681, 1035522654, 168447603);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(929607871, 2092475304, 1940221590, 196567546, 346458180, 2131041239, 1797649913, 162082500, 25639548, 1665178642, 1617231933, 1716426491, 1986475699, 262354389, 1517004243, 1058579789);
            int4x4 b2 = int4x4(91580624, 1974459648, 2074899534, 164782857, 1647410210, 1000391363, 1539243411, 1253927304, 894227825, 1897420927, 826437109, 139868307, 565247534, 1437897788, 1891416649, 1043772546);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(1006521329, 850817587, 270689979, 182908990, 512098264, 1555870818, 1824899010, 913664406, 38410741, 1365981133, 1517827659, 698699317, 522637780, 2135467596, 1812545145, 795262261);
            int4x4 b3 = int4x4(407784873, 516627611, 184196508, 1098113599, 1930819007, 693573550, 780517021, 48392683, 638156511, 356540844, 86920844, 103170762, 1952606997, 1374974056, 906153405, 602525178);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1211464300, 1921862607, 508076684, 1249127920, 1394594555, 746862310, 1733655277, 1884008277, 1682018538, 795585660, 936027116, 927605411, 672785749, 1465584610, 585324157, 404448210);
            int b0 = (746972502);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(969511077, 1772925698, 1884034177, 451512860, 425476075, 1370577708, 597010220, 1249636005, 211986678, 1305479811, 255635293, 1150443719, 177122433, 511346787, 1442445694, 667984966);
            int b1 = (442746747);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(1684122010, 172230876, 496695881, 955604291, 872759249, 811880239, 1604334190, 443527663, 1734064824, 1483978726, 1018945528, 476526026, 564821616, 1368099334, 2134154866, 2136028886);
            int b2 = (1962874832);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(20195989, 1256964339, 165389004, 759951440, 321496427, 551284899, 2058550111, 2146975562, 1182607877, 1588866146, 1478019984, 733564558, 1504896105, 284238873, 1641065069, 259620445);
            int b3 = (550465422);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_equal_scalar_wide()
        {
            int a0 = (1150044438);
            int4x4 b0 = int4x4(233855098, 924242519, 1402948791, 601381975, 2120518068, 629187703, 1971977031, 47183124, 1061805787, 1009011238, 312511148, 1460673064, 737210539, 1737844479, 1892405453, 2133024000);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (455818693);
            int4x4 b1 = int4x4(2003197687, 1276241219, 534746610, 559824292, 1758388240, 1023494292, 719963017, 1883763832, 597498209, 367814403, 1839429063, 223575614, 79701214, 1699606118, 759455864, 2017599457);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1395605233);
            int4x4 b2 = int4x4(1191785903, 1156248212, 338891967, 61410415, 1576985758, 1066598856, 1070606918, 1295956934, 1391539053, 1206456305, 466211205, 1362213007, 554347592, 361925309, 1122476040, 1118155036);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (2074160001);
            int4x4 b3 = int4x4(211145132, 1330427155, 231737739, 590220146, 622950505, 2048231874, 682985774, 865101790, 1523019859, 261373300, 132547968, 1971091157, 982104573, 1456888767, 1700538931, 1590557254);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_not_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1660932106, 982847023, 97046264, 1739517447, 1253499180, 1830584069, 1841470429, 1397841646, 1770890135, 1906548631, 169082967, 2099271786, 1909317609, 46519139, 1433204003, 931492669);
            int4x4 b0 = int4x4(107139049, 75478496, 2055495054, 358586687, 942338347, 111564990, 113811950, 948912488, 1080084121, 1400504872, 1032134499, 1061123400, 221862069, 858950046, 989094643, 2023070999);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(670504132, 1551558665, 1204055048, 1623586740, 226381077, 1145987803, 644253929, 475189890, 922313145, 2006448607, 1574579050, 1839580033, 155350910, 313644534, 2008975915, 1072866331);
            int4x4 b1 = int4x4(1269317127, 531883744, 687761409, 278427731, 296354221, 536981557, 1134676193, 1749879634, 1944210269, 92849031, 164029425, 628797607, 2069207270, 2022667842, 880567401, 264404537);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(10845678, 1588544505, 709736932, 1892341087, 1603981028, 1174123795, 2033630343, 416869471, 1894155826, 2084120548, 1130129683, 448491949, 1577220741, 376532834, 374116875, 416935463);
            int4x4 b2 = int4x4(1954996717, 572153302, 865957902, 1083128726, 1628120900, 2020212393, 1562290229, 774641416, 444123152, 1636477381, 838643638, 506474707, 922761058, 1282331425, 1748402545, 1493297323);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(1370971537, 526135879, 1693615335, 1040142702, 51869182, 636351650, 1137389277, 742650911, 1652337799, 128512016, 943930500, 1281758501, 1506504768, 1142416208, 489425068, 709011851);
            int4x4 b3 = int4x4(881583266, 836740859, 2050520235, 56355243, 923319881, 2093941797, 1966851287, 740544328, 1686486765, 1564852763, 1583872597, 1319685687, 1082069798, 1934459521, 610009662, 2003062130);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_not_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(747758183, 1033001286, 1439973882, 2138928797, 1197845089, 1432672459, 950170763, 238704450, 2105962247, 727205263, 1640688041, 276313906, 2126300423, 791998981, 2035077187, 1171827730);
            int b0 = (248693828);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(1412347883, 768370497, 1072798259, 1808712713, 1497830076, 1582645163, 1876273820, 90244766, 30493685, 904014575, 384643370, 11554610, 2016093187, 1515760622, 1596313927, 363921847);
            int b1 = (1622176923);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(1555396158, 1739138988, 1916670251, 1516209113, 765258490, 668154629, 1509386069, 1670155205, 6112585, 1942607934, 964072392, 779222124, 409389668, 321500037, 1728722181, 1641292942);
            int b2 = (913218907);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(780105497, 1311007738, 2079744789, 1086529117, 898347399, 1597839770, 1711183709, 2048684031, 1167351404, 528657884, 565527393, 227149840, 89869060, 1358928288, 44374114, 2059875706);
            int b3 = (1302143939);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_not_equal_scalar_wide()
        {
            int a0 = (2076921066);
            int4x4 b0 = int4x4(2037494727, 1989050616, 48833929, 1897435904, 514354517, 1783749164, 364694471, 754315072, 124108032, 1512967900, 1178825850, 1854793298, 50286949, 2100802631, 1640811853, 82110247);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (472172806);
            int4x4 b1 = int4x4(266984506, 2003668365, 1826089250, 1041416160, 356140110, 2057237962, 799920703, 1916347720, 510966350, 572038024, 1936481966, 1366859342, 1775285431, 604757336, 1047551607, 1311703338);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (676012224);
            int4x4 b2 = int4x4(627370253, 1715733805, 699755913, 1875151666, 358894860, 1036873378, 214171973, 340364269, 1652250278, 592713982, 806342921, 1264065574, 188560943, 1068608955, 485382245, 57935167);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1002934795);
            int4x4 b3 = int4x4(1859322106, 1990390938, 1674000894, 1035504906, 1681354617, 2079296301, 1396396873, 2128571831, 3388167, 1211711140, 575696152, 1534939377, 496306248, 908210564, 131274243, 543089960);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_wide_wide()
        {
            int4x4 a0 = int4x4(1182186063, 415538999, 1667335818, 1566618442, 1166180837, 639095188, 1080836365, 771119973, 928263233, 789225474, 665243110, 1003542034, 1032480172, 1961336172, 923379558, 21210619);
            int4x4 b0 = int4x4(524633529, 1032195686, 760723389, 1505751409, 431962172, 1287906509, 1560084663, 1450178202, 2066166337, 1107069023, 1640077524, 2103263105, 684229139, 1234033624, 1278743281, 1953079347);
            bool4x4 r0 = bool4x4(false, true, false, false, false, true, true, true, true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(1089772116, 1707633052, 778986024, 158153146, 336715101, 1839141169, 1706859710, 1928438162, 1638101724, 2044698552, 1543260981, 471462349, 1668575142, 2147199161, 946870864, 582371851);
            int4x4 b1 = int4x4(1228832942, 2082539723, 1088437561, 1058382082, 207459172, 750531081, 2015788562, 2126542133, 271967348, 1601249324, 1373999400, 1689592186, 459759541, 983106679, 332584818, 2034921203);
            bool4x4 r1 = bool4x4(true, true, true, true, false, false, true, true, false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(410751553, 198134393, 1999935258, 671192178, 1908013191, 770353922, 1948420002, 396403395, 903274624, 1743415547, 1381528376, 409818366, 757370593, 413964581, 1088722047, 111511218);
            int4x4 b2 = int4x4(833499488, 1999487070, 836063897, 1987309319, 1878327039, 457783938, 253010953, 1164175257, 1982277686, 651412210, 567444942, 1863256363, 18040866, 319226483, 1322530114, 4130283);
            bool4x4 r2 = bool4x4(true, true, false, true, false, false, false, true, true, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(1772570968, 339779528, 1817654169, 126606875, 1748258817, 1840719780, 603645478, 1888655831, 63356146, 79832055, 736652918, 653392827, 423681122, 1242116477, 422099316, 898587272);
            int4x4 b3 = int4x4(1951703613, 873360222, 2076434739, 802037827, 57389233, 1812417589, 13678411, 1415564189, 983023904, 1112076825, 2078443288, 1990790258, 482361677, 1981894392, 351965695, 585483077);
            bool4x4 r3 = bool4x4(true, true, true, true, false, false, false, false, true, true, true, true, true, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_wide_scalar()
        {
            int4x4 a0 = int4x4(608447185, 818840405, 869219329, 2080125385, 1214500548, 1361741203, 1667165786, 1615392341, 840091491, 469591900, 1247103789, 315321650, 930950514, 1100560246, 933855388, 908563901);
            int b0 = (1491216667);
            bool4x4 r0 = bool4x4(true, true, true, false, true, true, false, false, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(1127696709, 380753337, 971148054, 1827886929, 1056649851, 1579735991, 689044913, 1960894027, 371987110, 867559111, 1703747625, 1698536333, 41716206, 243673862, 1274625476, 611065092);
            int b1 = (1286331950);
            bool4x4 r1 = bool4x4(true, true, true, false, true, false, true, false, true, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(118750042, 452204442, 1645191336, 1829152606, 1891059504, 1217893177, 233590785, 894500093, 92899312, 965973603, 1496873003, 973411415, 694702440, 215973795, 1555455579, 1443255493);
            int b2 = (1829327996);
            bool4x4 r2 = bool4x4(true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(212954934, 1031281872, 1389987778, 928043903, 434566816, 1386588061, 180174416, 119231358, 842513438, 494182092, 2110901808, 2064339655, 798375285, 225918038, 2119961960, 1851740205);
            int b3 = (519181838);
            bool4x4 r3 = bool4x4(true, false, false, false, true, false, true, true, false, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_scalar_wide()
        {
            int a0 = (548436837);
            int4x4 b0 = int4x4(282703327, 14370648, 1862117300, 1304793311, 826073259, 988910157, 445132446, 1139670255, 111349251, 1102440676, 112183144, 1594415311, 1890019295, 2098715503, 608933527, 183989010);
            bool4x4 r0 = bool4x4(false, false, true, true, true, true, false, true, false, true, false, true, true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1596056507);
            int4x4 b1 = int4x4(1027318999, 146281093, 358911716, 874278078, 1106057699, 1256807459, 2111973919, 1736480659, 810406400, 1329939911, 1276652605, 593690439, 771851138, 590897155, 386688344, 1290583204);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1984930954);
            int4x4 b2 = int4x4(743544838, 1473400608, 1300775973, 1351720916, 168788814, 670661854, 168118205, 894264935, 1763013903, 1647476162, 699045651, 1813273687, 900504872, 1574770031, 1684716245, 1458270033);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (685700324);
            int4x4 b3 = int4x4(697607066, 378454814, 1198070277, 1821642406, 1324129275, 905046836, 1897627028, 1715796299, 15666859, 1806453893, 1315963488, 545979816, 1486981760, 511543521, 1872978447, 303832107);
            bool4x4 r3 = bool4x4(true, false, true, true, true, true, true, true, false, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_wide_wide()
        {
            int4x4 a0 = int4x4(592884447, 2133928932, 918957182, 1284069471, 194584707, 739120780, 241654068, 1340158550, 2099542537, 1182623667, 1399607274, 789301637, 180400925, 594688333, 1877031463, 1360073500);
            int4x4 b0 = int4x4(138737040, 192863971, 1700841444, 1044631301, 1391589821, 730837695, 253553987, 2078872742, 910845808, 976047676, 202633078, 1223618940, 641600530, 1830470354, 1570701388, 1104256103);
            bool4x4 r0 = bool4x4(true, true, false, true, false, true, false, false, true, true, true, false, false, false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(1091782422, 546676424, 348221770, 716039145, 458742739, 1365508046, 1523167942, 1574478622, 1295065160, 715285504, 1130323487, 677530432, 1496919050, 12463046, 1106153111, 1315083485);
            int4x4 b1 = int4x4(1838646932, 740166101, 1549021845, 1457092873, 1790630950, 907793213, 555122804, 1418910265, 335209251, 1094341422, 1465325455, 390251369, 910309992, 277356652, 1601082764, 771366966);
            bool4x4 r1 = bool4x4(false, false, false, false, false, true, true, true, true, false, false, true, true, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(31516321, 1786538920, 1854361210, 1730650972, 194806663, 517304937, 984608679, 1847934645, 1214605555, 535405194, 855415884, 2121416263, 1161116500, 1390730698, 1536558799, 350939762);
            int4x4 b2 = int4x4(1782348324, 550490783, 599992449, 550520692, 1873014441, 1756459971, 2028992071, 1772761768, 1323261715, 1541822212, 265732078, 1773940614, 156425055, 1585395425, 438682493, 1005143622);
            bool4x4 r2 = bool4x4(false, true, true, true, false, false, false, true, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(475547465, 876276892, 916067531, 1712032702, 752041926, 899534759, 948020518, 1553126337, 1209858994, 1210234744, 1065677570, 2063434729, 1808415708, 1536857930, 1356745398, 1161445540);
            int4x4 b3 = int4x4(594141080, 1888303265, 1023987839, 695072711, 164764812, 1404792693, 1068554108, 1615410626, 387184925, 1930375043, 1920744920, 1913267890, 12598306, 1697936155, 145255547, 1903607817);
            bool4x4 r3 = bool4x4(false, false, false, true, true, false, false, false, true, false, false, true, true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_wide_scalar()
        {
            int4x4 a0 = int4x4(1097138316, 211763648, 1883002501, 56406996, 43662641, 1923456111, 1437755186, 1219010035, 2125058448, 304028799, 893125636, 48044515, 711945018, 1035679270, 577943770, 572743717);
            int b0 = (438688675);
            bool4x4 r0 = bool4x4(true, false, true, false, false, true, true, true, true, false, true, false, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(1016617211, 1577403353, 64009107, 1462961460, 1143565920, 3715845, 689362811, 263973424, 1045140419, 1058332184, 524569092, 1183316983, 1107974092, 212839726, 523727054, 112709358);
            int b1 = (2063134811);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(614746280, 1683117650, 1451781409, 61102732, 1284938191, 1452639553, 2125085618, 467075658, 1019531089, 2028286621, 940955706, 1037153304, 1184928188, 1260010015, 1456174269, 174216269);
            int b2 = (1000986708);
            bool4x4 r2 = bool4x4(false, true, true, false, true, true, true, false, true, true, false, true, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(1930086291, 2112194236, 1797322269, 1781660503, 1442606402, 208047803, 1193639690, 1939917219, 1146005869, 865123927, 913186094, 35693052, 1017084356, 91189073, 369398582, 2082818804);
            int b3 = (108635332);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_scalar_wide()
        {
            int a0 = (2024896938);
            int4x4 b0 = int4x4(599356784, 185671342, 1932327391, 2025591013, 1257191721, 1312388500, 1443698859, 779217735, 691047512, 741776730, 732565983, 668302204, 1556466996, 858599525, 1896917159, 701542098);
            bool4x4 r0 = bool4x4(true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1052151621);
            int4x4 b1 = int4x4(1023307544, 1435392907, 1858177345, 299897686, 632930355, 1387203601, 483722222, 863042711, 1713088900, 315569296, 292652611, 1002628348, 927789921, 108145064, 425005337, 2093233588);
            bool4x4 r1 = bool4x4(true, false, false, true, true, false, true, true, false, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (2063431853);
            int4x4 b2 = int4x4(2079035844, 849337819, 1769234051, 358948261, 267985383, 126402553, 2055164423, 577620406, 1167389614, 474380256, 1163355187, 1782967398, 1648397169, 845981950, 630459977, 1033887217);
            bool4x4 r2 = bool4x4(false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (1480829811);
            int4x4 b3 = int4x4(1903710461, 402220631, 266619022, 1724999252, 2113910076, 945951388, 1448605169, 1162548302, 1691586468, 996819204, 1151046248, 1924073034, 1910741238, 633631666, 307560646, 722552263);
            bool4x4 r3 = bool4x4(false, true, true, false, false, true, true, true, false, true, true, false, false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1577248162, 2043073061, 1688380407, 176431985, 223299035, 1502802140, 1691709825, 386789394, 117182003, 1665770435, 1958490731, 420032601, 1251092689, 2011681765, 749743684, 183784440);
            int4x4 b0 = int4x4(903445031, 2108974565, 210822256, 1281704747, 453681718, 66138830, 1229799377, 1620922595, 1715833766, 1366430432, 13102000, 46919981, 486470891, 1709514236, 2145785285, 854254454);
            bool4x4 r0 = bool4x4(false, true, false, true, true, false, false, true, true, false, false, false, false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(1150674774, 1633828822, 1719442172, 336047314, 743733218, 1393995865, 1854442658, 1498138884, 912169992, 1992682021, 1619593455, 1883313982, 483412430, 857881876, 346624138, 531961063);
            int4x4 b1 = int4x4(1273278658, 810263315, 1862773824, 201799013, 974166844, 1320622967, 2058099616, 522102017, 620752145, 1213693681, 1281818305, 1564146162, 1996153080, 1201909516, 614401396, 224997397);
            bool4x4 r1 = bool4x4(true, false, true, false, true, false, true, false, false, false, false, false, true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(269897278, 1062947703, 1743454202, 2048964070, 1379786452, 622697214, 766589782, 339960970, 1135815654, 797344244, 153103264, 1382144646, 1537448323, 326850885, 1004891948, 2002658522);
            int4x4 b2 = int4x4(648547686, 418431167, 1724009726, 401891826, 1463971422, 984323887, 1246893281, 1340476720, 1489579748, 128991539, 1117574406, 2016340116, 69682660, 1870772739, 1281621445, 129331822);
            bool4x4 r2 = bool4x4(true, false, false, false, true, true, true, true, true, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(442205781, 1050725689, 995151913, 926131462, 719271722, 1981390876, 659121091, 797556380, 1656192110, 66093862, 1964540799, 71894133, 1413886687, 1028466491, 1397158841, 1544483525);
            int4x4 b3 = int4x4(1168998468, 1205894972, 1079707717, 1335643913, 1590790195, 155622033, 898990095, 1384002796, 1664888803, 1004528037, 402969524, 1299806519, 1194091234, 1673771542, 178191331, 98165007);
            bool4x4 r3 = bool4x4(true, true, true, true, true, false, true, true, true, true, false, true, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1722165358, 1219858357, 860410743, 411099660, 348104022, 1963256951, 212084836, 58924407, 1459242706, 1745758438, 532949158, 262559763, 690091301, 1806172431, 2091514001, 1857173043);
            int b0 = (1688048545);
            bool4x4 r0 = bool4x4(false, true, true, true, true, false, true, true, true, false, true, true, true, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(1617221948, 804204255, 981729559, 2032949254, 910922522, 2079225209, 26179915, 238796519, 1917813750, 1258115260, 20607406, 1337879822, 959460446, 1599429457, 1279143037, 1551937606);
            int b1 = (2017733017);
            bool4x4 r1 = bool4x4(true, true, true, false, true, false, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(626254356, 1021674613, 127839058, 1974631244, 426908235, 1818566980, 487782623, 1454736163, 465255784, 686095683, 2012624010, 1427922646, 1129062501, 1896996725, 1609784025, 1413823266);
            int b2 = (1162369122);
            bool4x4 r2 = bool4x4(true, true, true, false, true, false, true, false, true, true, false, false, true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(1483727269, 1823599046, 1379007149, 1836699751, 777126023, 1288116795, 834230828, 172303141, 577773919, 705141691, 191477430, 868528232, 499782260, 146328981, 1401289768, 858105804);
            int b3 = (2045244870);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_less_equal_scalar_wide()
        {
            int a0 = (1777585);
            int4x4 b0 = int4x4(1181030049, 1787703989, 1729760948, 1816537388, 1359786460, 874999193, 1678863148, 1711365839, 762067160, 11953554, 1131583906, 1175393186, 1293698493, 48893340, 66196247, 1958607116);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1576473309);
            int4x4 b1 = int4x4(861890786, 478252419, 957887737, 117849810, 1348693584, 105489302, 259034238, 530713566, 601413850, 830430286, 145552297, 1697295044, 1150680564, 2091065664, 1796096704, 1572008712);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, true, false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1556906486);
            int4x4 b2 = int4x4(205552788, 620963188, 1156705971, 1121867260, 733876180, 1570208446, 541165966, 644414754, 734807383, 938714737, 591783460, 56988751, 790541516, 1811299247, 1308256680, 549490410);
            bool4x4 r2 = bool4x4(false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (1987696011);
            int4x4 b3 = int4x4(1079808067, 363499438, 1873483674, 2031411422, 1979820112, 1682214687, 1470726710, 1285823822, 758372610, 44568907, 1533310851, 14070795, 1758870243, 68371537, 1482970849, 1750868121);
            bool4x4 r3 = bool4x4(false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_equal_wide_wide()
        {
            int4x4 a0 = int4x4(263000030, 744235661, 1893760267, 237248, 1062370984, 1676977687, 816766880, 1089431546, 1394493730, 1176473380, 1193988637, 1703862455, 1806186947, 1253571980, 589397635, 1951842887);
            int4x4 b0 = int4x4(1395535146, 1178373944, 1237373760, 1364855321, 600811864, 362060472, 290870624, 1839067862, 396958580, 1336888643, 1019684398, 1697684196, 1227300220, 2044269675, 1898323839, 874509380);
            bool4x4 r0 = bool4x4(false, false, true, false, true, true, true, false, true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(798931197, 808426484, 744869638, 1959531616, 207430702, 1533946595, 1148381840, 2011549474, 605043041, 1707339660, 2038122892, 345761584, 1839156338, 1519670644, 2131285427, 775457686);
            int4x4 b1 = int4x4(1873505472, 1268843918, 1606949562, 1263896445, 1805518202, 1412091359, 1240330374, 1955056253, 2025187918, 750755999, 869709740, 1390799279, 1194035112, 666460047, 103451220, 1311530792);
            bool4x4 r1 = bool4x4(false, false, false, true, false, true, false, true, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(796452624, 1710612922, 1629927787, 1094198224, 584910611, 1129457941, 1633221450, 549302356, 1363234393, 1439226634, 190984179, 983870135, 1527743888, 1577171227, 87278918, 1280094665);
            int4x4 b2 = int4x4(802468307, 1090745055, 1968071275, 1935027815, 2060060582, 1535954082, 291771096, 565856573, 1445999374, 711693364, 1201086888, 2076705104, 1565110852, 1698318173, 1293071569, 103979482);
            bool4x4 r2 = bool4x4(false, true, false, false, false, false, true, false, false, true, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(1030060516, 615638735, 1677201099, 325128466, 930989694, 165845388, 1887735446, 1905061476, 644732756, 1450709301, 811708233, 1120546613, 1966081819, 1710484814, 390900048, 1847748897);
            int4x4 b3 = int4x4(222415803, 345913533, 920804419, 784455413, 1919795492, 2125545957, 957291149, 1547385242, 953814071, 685286053, 63764322, 1742849383, 1781391465, 64816935, 1543363698, 1439322689);
            bool4x4 r3 = bool4x4(true, true, true, false, false, false, true, true, false, true, true, false, true, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(2112791350, 1043657935, 101764761, 1529909067, 556026890, 281734132, 1186600258, 815093894, 609211196, 1604309397, 829548642, 244604867, 1419295004, 471843809, 1819986195, 1460027917);
            int b0 = (1470533736);
            bool4x4 r0 = bool4x4(true, false, false, true, false, false, false, false, false, true, false, false, false, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(1646290021, 1596738181, 1905036391, 1771391775, 1584946560, 370941146, 440219668, 1607345862, 1449142607, 1223010129, 379014762, 1719435169, 258833609, 1389585003, 612593660, 42612027);
            int b1 = (196833647);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(1138747386, 917503963, 353608194, 1526792895, 192092521, 909358617, 367754234, 1738737389, 523396822, 594728703, 1332667659, 1627604854, 1542713928, 1997611484, 191413337, 1230701700);
            int b2 = (1491562090);
            bool4x4 r2 = bool4x4(false, false, false, true, false, false, false, true, false, false, false, true, true, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(702382564, 1013770865, 1420374964, 341399575, 2033070823, 672716789, 1809028740, 2070046852, 1254367930, 1206207650, 807585496, 1243142372, 350377587, 214724394, 216954982, 201992840);
            int b3 = (2086058548);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_greater_equal_scalar_wide()
        {
            int a0 = (1525542481);
            int4x4 b0 = int4x4(1503244746, 861711266, 817773856, 925984572, 571221723, 683686810, 118252990, 1653952090, 1240253990, 1947039008, 1869136019, 152012637, 1214546726, 917376832, 303549425, 2111728811);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, false, true, false, false, true, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (945321577);
            int4x4 b1 = int4x4(173706579, 625318949, 519443238, 1583588379, 1026799433, 1713083717, 394922760, 1216218189, 1336522452, 233894308, 479913036, 984991199, 172993285, 2121050903, 465645173, 788510727);
            bool4x4 r1 = bool4x4(true, true, true, false, false, false, true, false, false, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (337378780);
            int4x4 b2 = int4x4(273010835, 1898553615, 1111540136, 717385513, 474197678, 1417152771, 1476091619, 1312849725, 243299324, 1470872301, 1443256118, 1203165035, 2138148138, 1543595760, 186659728, 807288168);
            bool4x4 r2 = bool4x4(true, false, false, false, false, false, false, false, true, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1274079907);
            int4x4 b3 = int4x4(1834102381, 22983902, 1733648920, 2089437749, 476445313, 1296111196, 422851096, 1857250030, 1382182918, 449792502, 1785823601, 668960891, 1067260705, 1973471752, 1403490846, 1510985557);
            bool4x4 r3 = bool4x4(false, true, false, false, true, false, true, false, false, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_add_wide_wide()
        {
            int4x4 a0 = int4x4(2049228671, 1658660009, 491719392, 937013355, 81108663, 1063894558, 86954702, 843159721, 698977704, 192867135, 1683407172, 137301303, 2103582820, 526139155, 447937230, 2127411006);
            int4x4 b0 = int4x4(2088751567, 645762023, 306868786, 4360271, 506047997, 2094559874, 1634712736, 1601474440, 1586485231, 908746788, 1812370320, 1247342357, 2043773873, 223363428, 175115707, 985928617);
            int4x4 r0 = int4x4(-156987058, -1990545264, 798588178, 941373626, 587156660, -1136512864, 1721667438, -1850333135, -2009504361, 1101613923, -799189804, 1384643660, -147610603, 749502583, 623052937, -1181627673);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1670579390, 1914969141, 997691756, 857841794, 2129024875, 267535529, 978891383, 657092366, 941872903, 906908654, 1940071697, 862186205, 1951450264, 689662850, 1928213278, 1703906688);
            int4x4 b1 = int4x4(507662836, 1231457019, 776127866, 607782424, 1160366210, 1384832242, 702057048, 703554905, 2106992817, 1994483489, 539473, 236858351, 411317652, 595429166, 713649927, 2053476603);
            int4x4 r1 = int4x4(-2116725070, -1148541136, 1773819622, 1465624218, -1005576211, 1652367771, 1680948431, 1360647271, -1246101576, -1393575153, 1940611170, 1099044556, -1932199380, 1285092016, -1653104091, -537584005);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(526120638, 423980484, 1867227242, 603782684, 728643437, 927205560, 1544834791, 268450974, 1386681507, 1428974172, 1415690700, 1193340567, 1792960278, 1427490402, 86465016, 827052793);
            int4x4 b2 = int4x4(77965941, 1726775513, 1759186349, 2070333485, 1732568358, 523040962, 899952708, 1401525772, 1970067897, 488428060, 132927517, 1670039917, 1678110790, 586374104, 262412628, 1415374948);
            int4x4 r2 = int4x4(604086579, -2144211299, -668553705, -1620851127, -1833755501, 1450246522, -1850179797, 1669976746, -938217892, 1917402232, 1548618217, -1431586812, -823896228, 2013864506, 348877644, -2052539555);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(1603943169, 858711604, 278076564, 983811310, 1503210133, 1265840052, 1220817560, 839507207, 142866678, 1356231306, 1432159402, 637785903, 1032109021, 2081298882, 331695947, 1983868469);
            int4x4 b3 = int4x4(361542573, 900925442, 1077800500, 1330170201, 984058816, 207503339, 339145243, 1051497556, 1435620725, 2105629028, 1215478628, 393193121, 901424214, 189116452, 17408580, 466230809);
            int4x4 r3 = int4x4(1965485742, 1759637046, 1355877064, -1980985785, -1807698347, 1473343391, 1559962803, 1891004763, 1578487403, -833106962, -1647329266, 1030979024, 1933533235, -2024551962, 349104527, -1844868018);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_add_wide_scalar()
        {
            int4x4 a0 = int4x4(2038218457, 134923711, 875689667, 1338884463, 997710928, 340490871, 1067888129, 70433301, 2003021861, 1635971971, 1160398286, 85446202, 1068152966, 1239387100, 1497676888, 1727477485);
            int b0 = (2124409227);
            int4x4 r0 = int4x4(-132339612, -2035634358, -1294868402, -831673606, -1172847141, -1830067198, -1102669940, -2100124768, -167536208, -534586098, -1010159783, -2085111867, -1102405103, -931170969, -672881181, -443080584);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1095438654, 1818718931, 658923552, 1610518921, 1585755398, 692843300, 1068593469, 1704776233, 577782260, 736972565, 711894571, 564257439, 2051736283, 1572837697, 1628006545, 1855700263);
            int b1 = (756559204);
            int4x4 r1 = int4x4(1851997858, -1719689161, 1415482756, -1927889171, -1952652694, 1449402504, 1825152673, -1833631859, 1334341464, 1493531769, 1468453775, 1320816643, -1486671809, -1965570395, -1910401547, -1682707829);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(656748782, 1917133199, 828322973, 2116810190, 2092767444, 973587865, 1236931273, 504264449, 794292574, 1518058681, 1604636324, 354873417, 685247897, 227781140, 321182517, 1210575914);
            int b2 = (272774516);
            int4x4 r2 = int4x4(929523298, -2105059581, 1101097489, -1905382590, -1929425336, 1246362381, 1509705789, 777038965, 1067067090, 1790833197, 1877410840, 627647933, 958022413, 500555656, 593957033, 1483350430);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(1340503111, 1979965576, 1988286575, 427699536, 538653829, 1589564058, 1954579845, 1781591877, 419928668, 1751001953, 355993558, 1653659509, 2098769225, 63134274, 1679875388, 377229586);
            int b3 = (838567468);
            int4x4 r3 = int4x4(-2115896717, -1476434252, -1468113253, 1266267004, 1377221297, -1866835770, -1501819983, -1674807951, 1258496136, -1705397875, 1194561026, -1802740319, -1357630603, 901701742, -1776524440, 1215797054);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_add_scalar_wide()
        {
            int a0 = (391092078);
            int4x4 b0 = int4x4(519908870, 851424292, 328314822, 135622204, 740923360, 655394201, 1451896269, 1781697072, 996031825, 1557774949, 779774940, 1111541302, 783046445, 1130163944, 288279584, 1397683861);
            int4x4 r0 = int4x4(911000948, 1242516370, 719406900, 526714282, 1132015438, 1046486279, 1842988347, -2122178146, 1387123903, 1948867027, 1170867018, 1502633380, 1174138523, 1521256022, 679371662, 1788775939);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1636583489);
            int4x4 b1 = int4x4(673263339, 1469300874, 14855965, 1116636999, 1488863300, 1600990886, 190651301, 1307459768, 920085839, 2082229835, 1992405574, 1213924458, 505841452, 981421162, 1488337699, 1113826640);
            int4x4 r1 = int4x4(-1985120468, -1189082933, 1651439454, -1541746808, -1169520507, -1057392921, 1827234790, -1350924039, -1738297968, -576153972, -665978233, -1444459349, 2142424941, -1676962645, -1170046108, -1544557167);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1806146508);
            int4x4 b2 = int4x4(1841791222, 206610851, 526971953, 1236359886, 1459523189, 965740631, 82842799, 1298403201, 1805809772, 1978864191, 415003386, 1906304148, 722870197, 744248796, 1677223559, 303376031);
            int4x4 r2 = int4x4(-647029566, 2012757359, -1961848835, -1252460902, -1029297599, -1523080157, 1888989307, -1190417587, -683011016, -509956597, -2073817402, -582516640, -1765950591, -1744571992, -811597229, 2109522539);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1275565021);
            int4x4 b3 = int4x4(1518386617, 233426699, 1128986758, 1421938726, 1178529217, 1397917053, 137663521, 975646083, 1968321168, 720648013, 1606974342, 567772614, 490190373, 576353787, 1438920888, 2145198309);
            int4x4 r3 = int4x4(-1501015658, 1508991720, -1890415517, -1597463549, -1840873058, -1621485222, 1413228542, -2043756192, -1051081107, 1996213034, -1412427933, 1843337635, 1765755394, 1851918808, -1580481387, -874203966);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_sub_wide_wide()
        {
            int4x4 a0 = int4x4(1353441118, 797269833, 659988112, 56022121, 365847472, 2062899435, 1380988474, 799885138, 1306058185, 579775276, 1239163824, 344591081, 86359575, 1049709943, 721529513, 1767221271);
            int4x4 b0 = int4x4(1332656812, 1827794007, 972557431, 2078233689, 1508184327, 1372307701, 810327977, 936799885, 71562303, 1418723328, 1971342989, 1226053395, 136565478, 1979903295, 600719425, 837912956);
            int4x4 r0 = int4x4(20784306, -1030524174, -312569319, -2022211568, -1142336855, 690591734, 570660497, -136914747, 1234495882, -838948052, -732179165, -881462314, -50205903, -930193352, 120810088, 929308315);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(7652784, 545192611, 176298787, 1477774126, 1426963688, 2032787858, 2059525977, 445200454, 425848588, 2026967474, 1128492011, 61421784, 988065731, 1741434432, 2070331135, 1356704176);
            int4x4 b1 = int4x4(632054793, 711091688, 904695656, 1640069560, 750244414, 1385118097, 1102391291, 1221949855, 609588723, 1054324682, 1678086165, 1529581776, 1718700085, 523422634, 223602473, 1912611694);
            int4x4 r1 = int4x4(-624402009, -165899077, -728396869, -162295434, 676719274, 647669761, 957134686, -776749401, -183740135, 972642792, -549594154, -1468159992, -730634354, 1218011798, 1846728662, -555907518);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(1888446703, 1364654917, 265135366, 760501098, 741271824, 2139243287, 2086038778, 1314011065, 1838848671, 1554054707, 721235598, 1856904592, 570633009, 1870509604, 1310744871, 1717222072);
            int4x4 b2 = int4x4(1224986479, 748933681, 88793450, 401362529, 1087189363, 488919410, 1106956631, 1131451931, 1975243735, 111940790, 712896589, 477050266, 1163094482, 605082349, 954351492, 1203361215);
            int4x4 r2 = int4x4(663460224, 615721236, 176341916, 359138569, -345917539, 1650323877, 979082147, 182559134, -136395064, 1442113917, 8339009, 1379854326, -592461473, 1265427255, 356393379, 513860857);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(1541023885, 1644155041, 1885220021, 956814489, 1996571272, 313052858, 1686326525, 1591026645, 404689020, 832057610, 817031413, 1191376096, 1515565534, 178300672, 365767493, 1238101305);
            int4x4 b3 = int4x4(120176164, 834539498, 1843750420, 337055138, 1625604945, 41302648, 1719986021, 2028592747, 609982501, 95087400, 1244763386, 1175550114, 887604651, 1249524531, 155418749, 1934403979);
            int4x4 r3 = int4x4(1420847721, 809615543, 41469601, 619759351, 370966327, 271750210, -33659496, -437566102, -205293481, 736970210, -427731973, 15825982, 627960883, -1071223859, 210348744, -696302674);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_sub_wide_scalar()
        {
            int4x4 a0 = int4x4(1176369558, 1934521195, 309452150, 1417634074, 108910717, 1306356714, 1502312334, 1451794815, 281174200, 87530840, 1913724431, 2041593336, 557239990, 1119051448, 1590376732, 819090189);
            int b0 = (462232403);
            int4x4 r0 = int4x4(714137155, 1472288792, -152780253, 955401671, -353321686, 844124311, 1040079931, 989562412, -181058203, -374701563, 1451492028, 1579360933, 95007587, 656819045, 1128144329, 356857786);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(816382635, 1829033117, 1792801932, 1113440549, 1418937976, 1277257189, 2092779398, 642236742, 1605250794, 819644478, 1468003019, 128303186, 553494257, 1017126971, 1999744782, 2017272758);
            int b1 = (815920639);
            int4x4 r1 = int4x4(461996, 1013112478, 976881293, 297519910, 603017337, 461336550, 1276858759, -173683897, 789330155, 3723839, 652082380, -687617453, -262426382, 201206332, 1183824143, 1201352119);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(1817991764, 676974855, 1638032613, 949761204, 1835969317, 919015590, 976947310, 1304246606, 1456780208, 1554022712, 769804365, 2057831687, 758136579, 670433255, 603231411, 1673268965);
            int b2 = (1280985500);
            int4x4 r2 = int4x4(537006264, -604010645, 357047113, -331224296, 554983817, -361969910, -304038190, 23261106, 175794708, 273037212, -511181135, 776846187, -522848921, -610552245, -677754089, 392283465);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(941598524, 1394256067, 1267352835, 62929009, 1190778074, 657264006, 364156399, 775397332, 651143570, 486712236, 34309315, 1323491629, 1875163590, 1217887516, 2061463296, 24320578);
            int b3 = (2122131631);
            int4x4 r3 = int4x4(-1180533107, -727875564, -854778796, -2059202622, -931353557, -1464867625, -1757975232, -1346734299, -1470988061, -1635419395, -2087822316, -798640002, -246968041, -904244115, -60668335, -2097811053);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_sub_scalar_wide()
        {
            int a0 = (1691534405);
            int4x4 b0 = int4x4(2022393810, 1612688515, 496689713, 887037586, 2097630964, 374934538, 939035482, 935242277, 1789300421, 264712893, 1231856067, 1818112748, 1428436109, 1258745460, 1077380396, 1330722719);
            int4x4 r0 = int4x4(-330859405, 78845890, 1194844692, 804496819, -406096559, 1316599867, 752498923, 756292128, -97766016, 1426821512, 459678338, -126578343, 263098296, 432788945, 614154009, 360811686);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (518111829);
            int4x4 b1 = int4x4(967128529, 344666254, 1082267918, 907866696, 1816885123, 460340568, 962154498, 557113461, 1701216709, 1980098777, 730060552, 1444397827, 853570556, 138836432, 1013190428, 718089530);
            int4x4 r1 = int4x4(-449016700, 173445575, -564156089, -389754867, -1298773294, 57771261, -444042669, -39001632, -1183104880, -1461986948, -211948723, -926285998, -335458727, 379275397, -495078599, -199977701);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (506757390);
            int4x4 b2 = int4x4(1216448041, 936312747, 1997286455, 1969982026, 902880656, 1161220697, 1442464725, 622960765, 730968909, 614823841, 1889779020, 918322352, 133929920, 213123108, 1835450460, 521068072);
            int4x4 r2 = int4x4(-709690651, -429555357, -1490529065, -1463224636, -396123266, -654463307, -935707335, -116203375, -224211519, -108066451, -1383021630, -411564962, 372827470, 293634282, -1328693070, -14310682);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (2066839749);
            int4x4 b3 = int4x4(1982717309, 1580139939, 136826185, 783667709, 205508687, 1152347947, 1682018862, 329924125, 396414255, 542319408, 208974930, 1638328097, 935729865, 125876461, 218665639, 1100023218);
            int4x4 r3 = int4x4(84122440, 486699810, 1930013564, 1283172040, 1861331062, 914491802, 384820887, 1736915624, 1670425494, 1524520341, 1857864819, 428511652, 1131109884, 1940963288, 1848174110, 966816531);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mul_wide_wide()
        {
            int4x4 a0 = int4x4(245827027, 208934650, 1019478917, 568231809, 877289039, 1585782440, 2111178729, 1186019069, 571481445, 1570087048, 629447153, 619383734, 2055121568, 700402816, 263414349, 187830569);
            int4x4 b0 = int4x4(759663997, 350129201, 477450108, 1635735015, 388710278, 757722665, 1509388321, 1841703980, 1826369331, 1524322467, 1605207974, 428419155, 1460605791, 1968043860, 771161742, 2037340417);
            int4x4 r0 = int4x4(-632811769, 1402281434, 332447596, -1932977561, -1670918566, 1455036648, 2128344329, -594088068, -1654168033, 2093463192, -1207506618, -1133560830, 990589280, -938173952, -1341723466, 1156600361);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(2048056680, 546694675, 853585367, 933370718, 990212476, 1915885905, 1984212358, 368146234, 899438811, 1765718681, 409003054, 2069758852, 140280263, 442491280, 1924530939, 1372320666);
            int4x4 b1 = int4x4(322304267, 651448359, 1608326767, 1427155898, 1092185338, 665119139, 223634707, 694718952, 675813713, 999254223, 1326064110, 788102700, 1927999142, 1706356773, 747671596, 106127297);
            int4x4 r1 = int4x4(649177976, 678952165, 1063621177, -1611682740, -2142428392, -573253741, -1652113678, 1626072720, 1891467339, 335415735, 1128927428, -1656253776, -1433851638, 479369680, -366628060, -250163942);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(200879709, 857149632, 962693646, 988118613, 892998613, 534109991, 1836805716, 591690444, 1092459557, 1068605049, 1152926708, 1628337363, 400029062, 511168096, 1165835487, 1650108606);
            int4x4 b2 = int4x4(1695925670, 1788874462, 534570710, 1110638325, 142931150, 1684745462, 2101748242, 1831486861, 5683864, 1735084283, 1336059993, 721992570, 1906075622, 1073069872, 1374497592, 242540880);
            int4x4 r2 = int4x4(48406862, -1997863296, -275121228, -1483457191, 293009766, -617864326, 1179445736, -481780132, -1586128904, 1397450915, 487571412, -405680754, 326598756, 995119616, 638698952, 1153153376);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(1867348319, 464239430, 1513968722, 1879508953, 1835178747, 106255610, 791954119, 1098780631, 1336308698, 613897216, 1826550194, 1100684236, 67588307, 1388845400, 23402614, 2092286485);
            int4x4 b3 = int4x4(1809758608, 288286688, 726755419, 364868101, 655080356, 266071904, 385013390, 186015668, 758488066, 1918847075, 1784720030, 1012303363, 135157062, 1204101671, 2062532388, 1665984668);
            int4x4 r3 = int4x4(-1918112656, 2027161408, 1912621350, -108476099, 2728396, 1647526848, 418210914, 1845357612, 1544011700, -500859904, -1797693476, 468065124, -1956632398, 412191848, -1314817384, 1944145100);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mul_wide_scalar()
        {
            int4x4 a0 = int4x4(1762033447, 465343930, 1570757881, 1326409563, 1824319147, 1356578909, 72749215, 154616909, 975743632, 573770299, 1958912969, 971327747, 1818877398, 1324050764, 660611671, 1279757657);
            int b0 = (1476837906);
            int4x4 r0 = int4x4(-1313177922, 1326807828, -2138555518, -276153754, -65548794, -1318584182, -1839224530, -1720506518, 1736252960, -1699123674, -1534863838, -1853528010, -1668168436, -1977548968, 1423071262, 2117820994);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(391009467, 890343818, 800117742, 606927173, 1338014500, 1688964615, 1439447294, 387721300, 1192501703, 1613845584, 76318055, 124378112, 970518733, 1370700538, 1978842602, 1451974062);
            int b1 = (1186856590);
            int4x4 r1 = int4x4(1435732410, 218605196, 1896985092, -1774863802, -125434376, -750863902, -1084645148, 2141566616, -1063702942, 1813259360, -1722207966, -1862268928, 714733494, 209765036, 1993704396, 95853188);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(987919119, 1325430351, 948943118, 1743760648, 227492421, 217698851, 370371313, 309869840, 1389753586, 1895557060, 1449787207, 1817244670, 2117623142, 1951266912, 206918942, 382686790);
            int b2 = (1659987051);
            int4x4 r2 = int4x4(548860741, -775467259, 1518981338, 88896088, 1840817879, 997425313, -1094396229, 1277937072, 1861085478, -682201364, 98332333, -750570710, -1089412702, -1543745504, 438848394, -1975359678);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(396984449, 352046491, 1513331645, 1155106274, 138823406, 923862962, 131310587, 938688263, 631817444, 1890216972, 2143914807, 30238797, 5224899, 1350553408, 2127554014, 1666837332);
            int b3 = (474729765);
            int4x4 r3 = int4x4(-382607451, -596453785, -1450517679, 349983658, 1219417702, 1371907770, 443527751, 447592195, 903547124, -1196738116, -1447482893, -1178289119, -1553465297, -1288752064, 1864957718, 2131576612);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mul_scalar_wide()
        {
            int a0 = (99541948);
            int4x4 b0 = int4x4(1764461774, 657072478, 1459784358, 1610646683, 1632058826, 868441654, 1408757883, 335917146, 2105124483, 1178393968, 1963904348, 1409533767, 243286231, 1336308795, 517963367, 1733623488);
            int4x4 r0 = int4x4(-950398648, -102049016, 1260585960, 1158730452, -1606056, -466153048, 2108402516, 1966690328, 1623617844, -1691554240, -830512240, -1283699420, -628079900, 1294445652, 1610098852, -691055360);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (459880225);
            int4x4 b1 = int4x4(994616533, 1420531535, 1821413700, 677771573, 2132626845, 1158827713, 640102997, 944551639, 1323243330, 1186460236, 657101857, 1275563580, 1031291523, 1008470115, 1155301041, 1046199281);
            int4x4 r1 = int4x4(1378091637, 738687535, -826518076, -345210155, 316193853, 2121309665, -222642187, 1750778551, -1730990718, 133205964, 1859727169, 388250044, -611993629, -1492821565, -516072495, 1074594065);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (2138825098);
            int4x4 b2 = int4x4(1273008873, 1788343477, 1994364082, 597340263, 2022856151, 1375763101, 1007501105, 1162446628, 96412054, 1676576573, 1763698296, 729299033, 1534484, 1053621089, 1978013043, 796620370);
            int4x4 r2 = int4x4(1965095578, 1643380370, 1438423540, 15376006, -2086585114, 1819612578, -1355210390, -1011516056, -1566641956, -1061125150, -127290192, 1377278202, -2072591672, -368393398, 572695294, -1561208268);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (890235481);
            int4x4 b3 = int4x4(1880345584, 1882904983, 267128787, 1569254022, 1779318576, 1645728412, 819681361, 666095044, 308815496, 1829465065, 751656026, 1207837213, 1073832960, 169923853, 808603307, 363334486);
            int4x4 r3 = int4x4(-1302641040, -768431233, -337289637, 651297942, -2004494416, -2081501124, 1824177705, -904679132, 56997192, -381518335, 1427464010, 1396399637, 1642316800, -1259670651, -1066752141, -1714254618);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_div_wide_wide()
        {
            int4x4 a0 = int4x4(1590198532, 507812502, 126627032, 1058247011, 427387861, 290676154, 1829594484, 1127868739, 499016351, 1341209632, 134906097, 785470242, 788249865, 1099825433, 1552968283, 1822367139);
            int4x4 b0 = int4x4(1434703236, 911965201, 390415521, 128746927, 525835375, 816946613, 878264647, 146789678, 2089524057, 254213018, 1916850021, 1737806518, 1906634983, 437754923, 825037958, 902508708);
            int4x4 r0 = int4x4(1, 0, 0, 8, 0, 0, 2, 7, 0, 5, 0, 0, 0, 2, 1, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(1021812060, 1937073018, 645757349, 1097576782, 1246027674, 1152153253, 1900577195, 172149343, 1735128704, 816492592, 2012272185, 632330092, 649232994, 123715336, 1438073735, 723262291);
            int4x4 b1 = int4x4(896853614, 49452028, 1921327824, 787000669, 1032149621, 858558868, 1422112429, 837098844, 616122946, 2035322800, 1324534444, 1820832158, 917489631, 367475696, 620492088, 1749833550);
            int4x4 r1 = int4x4(1, 39, 0, 1, 1, 1, 1, 0, 2, 0, 1, 0, 0, 0, 2, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(850951883, 1942618200, 1088675276, 1648515976, 991947275, 1155668991, 764696768, 1984712970, 1734485640, 850109866, 8545366, 1037720170, 264523522, 1547702681, 1797612488, 1496410581);
            int4x4 b2 = int4x4(1535651093, 932740870, 1078416711, 725172174, 554208963, 1250240123, 2074395021, 1513621083, 262726589, 936845337, 1934527986, 1844761263, 116240860, 1875751365, 730101086, 625535586);
            int4x4 r2 = int4x4(0, 2, 1, 2, 1, 0, 0, 1, 6, 0, 0, 0, 2, 0, 2, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(308887330, 7606985, 1626977876, 1895907215, 1115090617, 1043375525, 168865453, 1056135390, 1080260308, 780473703, 1917865869, 1741288184, 497930923, 668217348, 1678197677, 1075043333);
            int4x4 b3 = int4x4(1549803350, 364926102, 1386892120, 656711993, 91320418, 1458063222, 1529573616, 722321620, 757577900, 1175347146, 1933900601, 1063907544, 97856937, 972434416, 1920248258, 261846189);
            int4x4 r3 = int4x4(0, 0, 1, 2, 12, 0, 0, 1, 1, 0, 0, 1, 5, 0, 0, 4);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_div_wide_scalar()
        {
            int4x4 a0 = int4x4(560951562, 1218680769, 375341724, 1613542090, 1919409166, 1397425408, 1349573078, 524526253, 341995568, 495895326, 1515313790, 1676971657, 2131487088, 2105094094, 1017891310, 542666029);
            int b0 = (947861580);
            int4x4 r0 = int4x4(0, 1, 0, 1, 2, 1, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(1646044372, 107215658, 19616726, 896899915, 707389627, 1249475421, 1486968988, 1738891885, 1919705924, 1244966864, 1200843642, 206442634, 1508567412, 1825701056, 1117255783, 929925156);
            int b1 = (1447236569);
            int4x4 r1 = int4x4(1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(1725332114, 1383839785, 2136282541, 159847918, 1515555001, 614923813, 1033495687, 1947230231, 1969254260, 1948672400, 757256792, 2099218773, 455629883, 324433498, 1679339858, 2024651647);
            int b2 = (1949103348);
            int4x4 r2 = int4x4(0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(1222061694, 1966139194, 1303421248, 1811535294, 240471953, 2116688995, 1035856383, 2022133852, 2147186889, 152458544, 148729436, 318083619, 980911803, 817677917, 398058007, 747046501);
            int b3 = (579280546);
            int4x4 r3 = int4x4(2, 3, 2, 3, 0, 3, 1, 3, 3, 0, 0, 0, 1, 1, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_div_scalar_wide()
        {
            int a0 = (1161272038);
            int4x4 b0 = int4x4(187325733, 1594107378, 2016183849, 1589343709, 388768753, 1417077283, 1773486938, 1154044032, 81831373, 1476877645, 653688843, 45756703, 631027637, 396671391, 784365696, 1250594097);
            int4x4 r0 = int4x4(6, 0, 0, 0, 2, 0, 0, 1, 14, 0, 1, 25, 1, 2, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1818363859);
            int4x4 b1 = int4x4(1653451772, 270557729, 48974453, 1796936382, 1427856423, 981056957, 1955700573, 705450043, 1054404890, 351914083, 131970646, 1320586926, 366944102, 1575786200, 257204865, 1582754309);
            int4x4 r1 = int4x4(1, 6, 37, 1, 1, 1, 0, 2, 1, 5, 13, 1, 4, 1, 7, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (2114509003);
            int4x4 b2 = int4x4(1266146708, 45105265, 2092444751, 407744534, 126616016, 1900058250, 523718813, 414718546, 1828540203, 860638950, 1827704212, 182494419, 669579562, 717750865, 560379939, 681272719);
            int4x4 r2 = int4x4(1, 46, 1, 5, 16, 1, 4, 5, 1, 2, 1, 11, 3, 2, 3, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (638134699);
            int4x4 b3 = int4x4(297472499, 1196796276, 815483831, 1511819303, 906952957, 613050421, 60483276, 883893666, 1481847510, 1065163200, 1641516292, 1980940753, 1862370918, 2048575092, 396483978, 610486041);
            int4x4 r3 = int4x4(2, 0, 0, 0, 0, 1, 10, 0, 0, 0, 0, 0, 0, 0, 1, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mod_wide_wide()
        {
            int4x4 a0 = int4x4(146150818, 1846543305, 1071447756, 308965362, 659881575, 1002365460, 861198439, 1510617532, 778525078, 1458458044, 101987897, 1249565173, 938026607, 1692541775, 1518877124, 1806965510);
            int4x4 b0 = int4x4(983050390, 771341152, 942375212, 367361754, 749500619, 750718852, 2095151755, 88438806, 769227442, 647214624, 1026513788, 1544950956, 160166322, 1099108075, 1158422232, 1798905209);
            int4x4 r0 = int4x4(146150818, 303861001, 129072544, 308965362, 659881575, 251646608, 861198439, 7157830, 9297636, 164028796, 101987897, 1249565173, 137194997, 593433700, 360454892, 8060301);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(1325139851, 994457255, 1372400564, 1770508529, 100255877, 452674793, 1545968777, 629019189, 1402964707, 2138294579, 1641714420, 1782022072, 1880968864, 1980798192, 1397317084, 995968277);
            int4x4 b1 = int4x4(164686701, 327889784, 1082162785, 1213537518, 608481038, 329133821, 1824387961, 1223426748, 798137669, 79717779, 1233582258, 1267120677, 301592349, 911281434, 1357340934, 1648942990);
            int4x4 r1 = int4x4(7646243, 10787903, 290237779, 556971011, 100255877, 123540972, 1545968777, 629019189, 604827038, 65632325, 408132162, 514901395, 71414770, 158235324, 39976150, 995968277);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1090018756, 1573062648, 1100694500, 863521889, 1146202560, 546958747, 573838995, 2146465826, 1678630780, 1843627015, 1167611300, 157190789, 530148276, 594404567, 1248848240, 1963704081);
            int4x4 b2 = int4x4(1350943898, 696511738, 1182727748, 1843845940, 244920526, 1640990506, 920431352, 1261122293, 469115027, 720739455, 1727247731, 91557593, 1874820225, 1070808215, 859227095, 890398590);
            int4x4 r2 = int4x4(1090018756, 180039172, 1100694500, 863521889, 166520456, 546958747, 573838995, 885343533, 271285699, 402148105, 1167611300, 65633196, 530148276, 594404567, 389621145, 182906901);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(1759996408, 1386598712, 251325313, 122732248, 2082099427, 1080998866, 686623511, 693281682, 302610170, 1380134301, 1661197566, 481331690, 1193753109, 166363462, 588323181, 594997700);
            int4x4 b3 = int4x4(951215450, 195024879, 2079991098, 220236959, 294448639, 1396793894, 141031566, 960537512, 719675899, 928202057, 275228822, 1510254672, 1481505055, 1373357922, 1940197321, 286975465);
            int4x4 r3 = int4x4(808780958, 21424559, 251325313, 122732248, 20958954, 1080998866, 122497247, 693281682, 302610170, 451932244, 9824634, 481331690, 1193753109, 166363462, 588323181, 21046770);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mod_wide_scalar()
        {
            int4x4 a0 = int4x4(164800505, 1062177828, 1898749675, 1701653318, 820393245, 19002208, 128329633, 1464010899, 896587769, 405208598, 1982762194, 959236935, 712321026, 172564850, 1540068445, 1085897743);
            int b0 = (883951171);
            int4x4 r0 = int4x4(164800505, 178226657, 130847333, 817702147, 820393245, 19002208, 128329633, 580059728, 12636598, 405208598, 214859852, 75285764, 712321026, 172564850, 656117274, 201946572);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(1607489717, 647846716, 915707999, 1602830401, 928191283, 1084934806, 488509689, 2087820912, 377501313, 1778384846, 1216011754, 812183417, 1153802502, 1642671870, 1924710742, 665297470);
            int b1 = (165478511);
            int4x4 r1 = int4x4(118183118, 151411183, 88315444, 113523802, 100798728, 92063740, 157552667, 102078780, 46544291, 123599736, 57662177, 150269373, 160931436, 153365271, 104447121, 3383426);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1568090825, 435886407, 453990946, 1731665372, 586777590, 1475597526, 1585649515, 1414579860, 1891664981, 1262495021, 1400758118, 1529532008, 430295164, 1386414018, 2130346558, 666621411);
            int b2 = (2050982942);
            int4x4 r2 = int4x4(1568090825, 435886407, 453990946, 1731665372, 586777590, 1475597526, 1585649515, 1414579860, 1891664981, 1262495021, 1400758118, 1529532008, 430295164, 1386414018, 79363616, 666621411);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(1524342239, 1547690684, 857915601, 709453751, 2103243535, 2124726669, 1410239986, 1761316053, 442891932, 388101009, 1059801526, 651827482, 1890268914, 910020375, 58051452, 293939465);
            int b3 = (1490592900);
            int4x4 r3 = int4x4(33749339, 57097784, 857915601, 709453751, 612650635, 634133769, 1410239986, 270723153, 442891932, 388101009, 1059801526, 651827482, 399676014, 910020375, 58051452, 293939465);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_mod_scalar_wide()
        {
            int a0 = (242383789);
            int4x4 b0 = int4x4(740000543, 1556450291, 1104736385, 437976569, 1911837205, 1507212038, 1906405167, 247693265, 293460573, 1495295166, 873323603, 530681233, 1298102643, 2057984657, 1000742091, 1461372131);
            int4x4 r0 = int4x4(242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1859742342);
            int4x4 b1 = int4x4(797184687, 821888842, 1083192997, 840114986, 1894865954, 615159964, 1485575122, 2028738, 2122220318, 164578061, 730088119, 1444946139, 1305792037, 1110829011, 872723581, 166847388);
            int4x4 r1 = int4x4(265372968, 215964658, 776549345, 179512370, 1859742342, 14262450, 374167220, 1418334, 1859742342, 49383671, 399566104, 414796203, 553950305, 748913331, 114295180, 24421074);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1477846418);
            int4x4 b2 = int4x4(511428733, 1642227542, 1962310765, 207128894, 1342085447, 448361286, 334667519, 705465751, 753088773, 1146344010, 275140144, 1074480141, 2092749846, 1631900558, 2088387496, 1098441751);
            int4x4 r2 = int4x4(454988952, 1477846418, 1477846418, 27944160, 135760971, 132762560, 139176342, 66914916, 724757645, 331502408, 102145698, 403366277, 1477846418, 1477846418, 1477846418, 379404667);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (1648646354);
            int4x4 b3 = int4x4(1730303822, 859376331, 889118656, 1549752450, 992618236, 941290327, 1766644910, 435947831, 1937100534, 1342633977, 1176317048, 950230773, 1135152183, 384466155, 600022, 363833845);
            int4x4 r3 = int4x4(1648646354, 789270023, 759527698, 98893904, 656028118, 707356027, 1648646354, 340802861, 1648646354, 306012377, 472329306, 698415581, 513494171, 110781734, 385920, 193310974);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_plus()
        {
            int4x4 a0 = int4x4(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897, 1287765427, 849339193, 174532915, 1864850812, 1566098441, 1145639744, 1615499926);
            int4x4 r0 = int4x4(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897, 1287765427, 849339193, 174532915, 1864850812, 1566098441, 1145639744, 1615499926);
            TestUtils.AreEqual(+a0, r0);

            int4x4 a1 = int4x4(2049663954, 409076474, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939, 308695413, 1575280693, 2067379018, 1673126612, 500666137, 640289062, 836003812, 336058393);
            int4x4 r1 = int4x4(2049663954, 409076474, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939, 308695413, 1575280693, 2067379018, 1673126612, 500666137, 640289062, 836003812, 336058393);
            TestUtils.AreEqual(+a1, r1);

            int4x4 a2 = int4x4(829347661, 381670450, 277507230, 361395485, 1012749225, 1204186973, 2092803800, 1459040742, 531853559, 2093894901, 1589622197, 1559976318, 619729461, 731886792, 1441425968, 1921783986);
            int4x4 r2 = int4x4(829347661, 381670450, 277507230, 361395485, 1012749225, 1204186973, 2092803800, 1459040742, 531853559, 2093894901, 1589622197, 1559976318, 619729461, 731886792, 1441425968, 1921783986);
            TestUtils.AreEqual(+a2, r2);

            int4x4 a3 = int4x4(1257555634, 578585280, 1087392044, 2084329354, 300198860, 1247120404, 1325809345, 1057524082, 1426592020, 167918579, 1552986194, 813448514, 2048383407, 647476365, 13335381, 1985958169);
            int4x4 r3 = int4x4(1257555634, 578585280, 1087392044, 2084329354, 300198860, 1247120404, 1325809345, 1057524082, 1426592020, 167918579, 1552986194, 813448514, 2048383407, 647476365, 13335381, 1985958169);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_neg()
        {
            int4x4 a0 = int4x4(1955022112, 662160019, 370300775, 2141283773, 1004505619, 28153593, 33894270, 505708349, 1115028238, 1636274969, 694995093, 1542206286, 213087293, 243937487, 341522275, 841085242);
            int4x4 r0 = int4x4(-1955022112, -662160019, -370300775, -2141283773, -1004505619, -28153593, -33894270, -505708349, -1115028238, -1636274969, -694995093, -1542206286, -213087293, -243937487, -341522275, -841085242);
            TestUtils.AreEqual(-a0, r0);

            int4x4 a1 = int4x4(574159094, 2057919693, 1175014732, 1259809073, 1212465326, 1190569920, 2047955772, 2120729864, 1440774928, 1485596454, 431666091, 1387601718, 1745651998, 319115626, 1119959806, 739132284);
            int4x4 r1 = int4x4(-574159094, -2057919693, -1175014732, -1259809073, -1212465326, -1190569920, -2047955772, -2120729864, -1440774928, -1485596454, -431666091, -1387601718, -1745651998, -319115626, -1119959806, -739132284);
            TestUtils.AreEqual(-a1, r1);

            int4x4 a2 = int4x4(1954173314, 1836511050, 1662806453, 506144868, 650922971, 1755382554, 1273997249, 1474445187, 1853826947, 1695573773, 729452512, 345069360, 575867536, 594119038, 1201840609, 1342872551);
            int4x4 r2 = int4x4(-1954173314, -1836511050, -1662806453, -506144868, -650922971, -1755382554, -1273997249, -1474445187, -1853826947, -1695573773, -729452512, -345069360, -575867536, -594119038, -1201840609, -1342872551);
            TestUtils.AreEqual(-a2, r2);

            int4x4 a3 = int4x4(1768435578, 23008237, 1410502890, 695213039, 1342131852, 1619073746, 469828650, 20553909, 1711214338, 690040786, 1749711826, 1265590278, 1516859887, 1317159343, 1722518934, 803074002);
            int4x4 r3 = int4x4(-1768435578, -23008237, -1410502890, -695213039, -1342131852, -1619073746, -469828650, -20553909, -1711214338, -690040786, -1749711826, -1265590278, -1516859887, -1317159343, -1722518934, -803074002);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_prefix_inc()
        {
            int4x4 a0 = int4x4(864455342, 2035793213, 1275443862, 971919915, 411610189, 446210725, 395072276, 115573442, 913293639, 432884105, 1208161871, 1385544935, 1835605516, 831396561, 388229350, 696475402);
            int4x4 r0 = int4x4(864455343, 2035793214, 1275443863, 971919916, 411610190, 446210726, 395072277, 115573443, 913293640, 432884106, 1208161872, 1385544936, 1835605517, 831396562, 388229351, 696475403);
            TestUtils.AreEqual(++a0, r0);

            int4x4 a1 = int4x4(1786514683, 752093909, 1622410417, 1398865015, 241906003, 1705625817, 609525897, 172599489, 504806865, 519296647, 281942776, 1541894135, 924683935, 259568871, 1349062584, 1120518661);
            int4x4 r1 = int4x4(1786514684, 752093910, 1622410418, 1398865016, 241906004, 1705625818, 609525898, 172599490, 504806866, 519296648, 281942777, 1541894136, 924683936, 259568872, 1349062585, 1120518662);
            TestUtils.AreEqual(++a1, r1);

            int4x4 a2 = int4x4(65514038, 1321109497, 1366348660, 1777734111, 1414867743, 536776365, 539531120, 886558347, 1733014170, 1586973907, 1145067277, 884064327, 82551838, 1001250037, 924273925, 242241802);
            int4x4 r2 = int4x4(65514039, 1321109498, 1366348661, 1777734112, 1414867744, 536776366, 539531121, 886558348, 1733014171, 1586973908, 1145067278, 884064328, 82551839, 1001250038, 924273926, 242241803);
            TestUtils.AreEqual(++a2, r2);

            int4x4 a3 = int4x4(413165245, 1206806909, 2069192976, 1613073974, 1342402025, 330167396, 665917965, 799320426, 2054286971, 2074397725, 113129500, 721162954, 2136093351, 173315234, 2006582934, 265026274);
            int4x4 r3 = int4x4(413165246, 1206806910, 2069192977, 1613073975, 1342402026, 330167397, 665917966, 799320427, 2054286972, 2074397726, 113129501, 721162955, 2136093352, 173315235, 2006582935, 265026275);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_postfix_inc()
        {
            int4x4 a0 = int4x4(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607, 708474528, 177416855, 1524860667, 1408994706, 375284401, 1580130369, 1676086778);
            int4x4 r0 = int4x4(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607, 708474528, 177416855, 1524860667, 1408994706, 375284401, 1580130369, 1676086778);
            TestUtils.AreEqual(a0++, r0);

            int4x4 a1 = int4x4(717006530, 732199129, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160, 357567451, 1468020171, 1949784665, 1127356901, 101238629, 2131648021, 423320704, 827539403);
            int4x4 r1 = int4x4(717006530, 732199129, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160, 357567451, 1468020171, 1949784665, 1127356901, 101238629, 2131648021, 423320704, 827539403);
            TestUtils.AreEqual(a1++, r1);

            int4x4 a2 = int4x4(1919960927, 2010345998, 1047836590, 586887730, 1209169651, 1051531454, 1479717664, 1874959449, 104723114, 817246348, 1972950889, 1784631804, 1550936382, 718649502, 872906800, 717529320);
            int4x4 r2 = int4x4(1919960927, 2010345998, 1047836590, 586887730, 1209169651, 1051531454, 1479717664, 1874959449, 104723114, 817246348, 1972950889, 1784631804, 1550936382, 718649502, 872906800, 717529320);
            TestUtils.AreEqual(a2++, r2);

            int4x4 a3 = int4x4(1995020676, 183815949, 1207670946, 1620827725, 1809811548, 1643094131, 280506984, 382615051, 650280741, 560631765, 1840722506, 63273626, 1294940978, 724310154, 1901579798, 697321264);
            int4x4 r3 = int4x4(1995020676, 183815949, 1207670946, 1620827725, 1809811548, 1643094131, 280506984, 382615051, 650280741, 560631765, 1840722506, 63273626, 1294940978, 724310154, 1901579798, 697321264);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_prefix_dec()
        {
            int4x4 a0 = int4x4(200904609, 871077500, 968578728, 638967721, 1995396216, 435367037, 1782514098, 1589827826, 1434377580, 596759698, 1699290403, 1758478358, 1914114460, 71237375, 389120307, 1022184392);
            int4x4 r0 = int4x4(200904608, 871077499, 968578727, 638967720, 1995396215, 435367036, 1782514097, 1589827825, 1434377579, 596759697, 1699290402, 1758478357, 1914114459, 71237374, 389120306, 1022184391);
            TestUtils.AreEqual(--a0, r0);

            int4x4 a1 = int4x4(1310293956, 18299409, 906734601, 799006218, 1383897383, 1040798388, 1469596990, 1719228297, 220897829, 1454322707, 678025545, 14227726, 293093918, 1065286595, 1249415499, 1009503100);
            int4x4 r1 = int4x4(1310293955, 18299408, 906734600, 799006217, 1383897382, 1040798387, 1469596989, 1719228296, 220897828, 1454322706, 678025544, 14227725, 293093917, 1065286594, 1249415498, 1009503099);
            TestUtils.AreEqual(--a1, r1);

            int4x4 a2 = int4x4(157482354, 1797304434, 1083672612, 929765380, 2083512379, 2045544045, 323646560, 1395297406, 583796119, 999841714, 1788073019, 1618852114, 1777032041, 1252764958, 1070818447, 219340317);
            int4x4 r2 = int4x4(157482353, 1797304433, 1083672611, 929765379, 2083512378, 2045544044, 323646559, 1395297405, 583796118, 999841713, 1788073018, 1618852113, 1777032040, 1252764957, 1070818446, 219340316);
            TestUtils.AreEqual(--a2, r2);

            int4x4 a3 = int4x4(767990877, 366067423, 99249400, 1549382038, 1105868582, 1977762759, 1646465385, 1067223071, 1774498387, 1128527977, 1104488553, 1575600100, 1141283662, 1678956750, 449874904, 748975258);
            int4x4 r3 = int4x4(767990876, 366067422, 99249399, 1549382037, 1105868581, 1977762758, 1646465384, 1067223070, 1774498386, 1128527976, 1104488552, 1575600099, 1141283661, 1678956749, 449874903, 748975257);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_postfix_dec()
        {
            int4x4 a0 = int4x4(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285, 2017728859, 802721301, 377162390, 526366486, 1504625034, 590919177, 60677868);
            int4x4 r0 = int4x4(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285, 2017728859, 802721301, 377162390, 526366486, 1504625034, 590919177, 60677868);
            TestUtils.AreEqual(a0--, r0);

            int4x4 a1 = int4x4(1867810045, 670715645, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208, 1931943579, 175622377, 181847458, 665549439, 530897466, 635466911);
            int4x4 r1 = int4x4(1867810045, 670715645, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881, 1726583208, 1931943579, 175622377, 181847458, 665549439, 530897466, 635466911);
            TestUtils.AreEqual(a1--, r1);

            int4x4 a2 = int4x4(416440036, 1444496274, 296146626, 1209855130, 2016700604, 838640502, 647102652, 1948542169, 659874422, 2009120584, 1577004911, 1809041177, 518526567, 1464738365, 1815629310, 1216839298);
            int4x4 r2 = int4x4(416440036, 1444496274, 296146626, 1209855130, 2016700604, 838640502, 647102652, 1948542169, 659874422, 2009120584, 1577004911, 1809041177, 518526567, 1464738365, 1815629310, 1216839298);
            TestUtils.AreEqual(a2--, r2);

            int4x4 a3 = int4x4(569144612, 509007463, 860240975, 41334109, 10321636, 1940079495, 43143738, 1044950720, 63756334, 1595004937, 699747920, 348534360, 509361827, 1352179420, 271823835, 1889179126);
            int4x4 r3 = int4x4(569144612, 509007463, 860240975, 41334109, 10321636, 1940079495, 43143738, 1044950720, 63756334, 1595004937, 699747920, 348534360, 509361827, 1352179420, 271823835, 1889179126);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_and_wide_wide()
        {
            int4x4 a0 = int4x4(779935043, 1097962163, 1939593304, 800599247, 952140918, 782792558, 1608557706, 396446406, 2039894114, 1286974642, 442394124, 1759739564, 233435438, 665207770, 1942050241, 1022352952);
            int4x4 b0 = int4x4(307705143, 1710882162, 866836769, 532490608, 679371720, 1794035877, 1439832202, 519529812, 23633139, 1209152681, 646737179, 1255867027, 1900854122, 413173763, 1409138251, 2087190272);
            int4x4 r0 = int4x4(39064835, 1097961522, 864731136, 263727168, 675283008, 715673636, 1438646410, 379666500, 16781410, 1209017504, 34366472, 1220739712, 21541162, 10485762, 1405162561, 1013440000);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(60340400, 329119345, 406517382, 1126764634, 343425836, 1957552749, 1624478957, 341972372, 181537307, 130347414, 1240828622, 526120460, 695449226, 1477446724, 201628999, 737924014);
            int4x4 b1 = int4x4(563439483, 354579077, 642224854, 1650432515, 755290290, 902865191, 661389406, 2134212586, 1855189321, 185194029, 810374380, 133197864, 1989578783, 38739182, 387425484, 1690486314);
            int4x4 r1 = int4x4(26222640, 285241857, 168582, 1107890178, 67125280, 880844837, 541065292, 337646976, 177340425, 50384900, 4522188, 122712072, 538087434, 3140, 67404868, 549634602);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(1804502415, 1733695477, 1110712857, 113012430, 1044352152, 865726845, 836668077, 1778871717, 1558881750, 231636456, 1278790837, 846361650, 37319023, 1806613498, 1312261777, 1448803516);
            int4x4 b2 = int4x4(843085933, 1045118223, 41867329, 1397669260, 1784025774, 1834587481, 856874373, 1719529679, 678478831, 86860920, 837158923, 1397449667, 195921481, 564422246, 1088025452, 2103483999);
            int4x4 r2 = int4x4(570425357, 641864965, 36962305, 34352268, 706085000, 555323737, 823298181, 1644519557, 140542406, 84698216, 2099201, 306339842, 36241481, 564404834, 1074889216, 1413520412);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(17366276, 1245846423, 1075177576, 1023499729, 1742176891, 1288325524, 2092131182, 1444013434, 210707066, 627341079, 155789028, 411695477, 2144207930, 1007799200, 382737478, 85407483);
            int4x4 b3 = int4x4(267066435, 781393024, 1444337796, 139669978, 880161801, 1604286495, 839016626, 1986058500, 1905400692, 1670633815, 651063094, 967343492, 336245810, 914791376, 1696073831, 2103810347);
            int4x4 r3 = int4x4(17308672, 167909504, 1075103744, 134287824, 609615881, 1284130836, 805462050, 1442889984, 8520304, 553668887, 4728356, 411597060, 336200754, 872450944, 68159558, 84217899);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_and_wide_scalar()
        {
            int4x4 a0 = int4x4(443615469, 490057985, 2042441263, 1524760558, 1405175110, 510212004, 1941875181, 1236735839, 1365509729, 428270198, 607982857, 650270920, 1249238550, 814629680, 1862276471, 143502472);
            int b0 = (93423598);
            int4x4 r0 = int4x4(1114348, 85033216, 26281518, 8488942, 25232710, 67176356, 26247660, 26281806, 16778848, 25199206, 68224264, 75497672, 1148422, 8389408, 83887462, 8488072);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(861733033, 957693145, 1567715668, 1102952410, 322053683, 1599352836, 208656708, 1272226025, 462670926, 1817145060, 1466722981, 1817277774, 818900583, 772681077, 1630437952, 546018772);
            int b1 = (1408932942);
            int4x4 r1 = int4x4(324534280, 286268488, 1366298692, 1102615626, 322044930, 1397755908, 6985796, 1137737800, 328371278, 1078594628, 1399326724, 1078989902, 281676870, 34212932, 1093304384, 9081924);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(872875431, 708719245, 1764446048, 1527981061, 398141788, 156911041, 554819377, 1683835293, 972562207, 393685571, 2118911919, 1503487659, 283854137, 1911282206, 312686024, 384581172);
            int b2 = (1143080525);
            int4x4 r2 = int4x4(67240965, 2228749, 1075971648, 1073873925, 69337164, 132161, 1537, 1140850701, 2098701, 69337665, 1140852237, 1073743369, 2229257, 1075970572, 2229320, 69207556);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(1826788967, 3292432, 225233484, 1488146706, 1918853562, 1038188796, 1833784555, 252534533, 942504184, 840550591, 475152200, 1566941712, 546609146, 1803072768, 1125028552, 104252148);
            int b3 = (150752148);
            int4x4 r3 = int4x4(148898308, 3148048, 141314564, 145768720, 6046096, 148897940, 139214976, 135023364, 137119888, 1591444, 139463424, 140771856, 9700240, 142082304, 787072, 3424916);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1144543590);
            int4x4 b0 = int4x4(420346723, 562416448, 1393127318, 1560699552, 851218057, 703880958, 1159378889, 2031211279, 1089518981, 270607307, 1349288930, 520199596, 1763483957, 1248975349, 236938635, 185023291);
            int4x4 r0 = int4x4(547170, 18752, 1074284806, 1140867104, 3672064, 3168358, 1142427968, 1074811142, 1076893956, 2097474, 1076363618, 67115300, 1075314980, 1076910436, 68698370, 6434);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1085233038);
            int4x4 b1 = int4x4(1845693112, 946052961, 1436238522, 2042776519, 56356886, 1770159840, 1872339579, 1439201366, 1233066417, 1214109404, 2255485, 1814885263, 1711986588, 1286898282, 915476451, 1870138851);
            int4x4 r1 = int4x4(1073939080, 2299648, 1082868362, 1082278790, 741382, 1082283648, 1082720778, 1082675206, 1076826496, 1074615948, 2245132, 1076646798, 1074419596, 1084490250, 8456066, 1076364674);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (372814411);
            int4x4 b2 = int4x4(1623486506, 211665304, 1668985777, 348112007, 1808619374, 1516730209, 1647041932, 350465899, 1641369007, 1555310928, 857924828, 1980404095, 34923708, 1073528483, 742357726, 1244015681);
            int4x4 r2 = int4x4(12298, 68714504, 37270017, 339247107, 34083402, 304099905, 36212744, 337683019, 1048587, 338698304, 304128072, 369659979, 34643976, 372814339, 70791754, 35659841);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1980296380);
            int4x4 b3 = int4x4(1295368015, 859181113, 1741688223, 1249250718, 363989837, 939740255, 1668271386, 121498186, 1765635287, 1637255201, 1157123404, 216326016, 1525016040, 1131192672, 433812479, 797544392);
            int4x4 r3 = int4x4(1140894732, 838860856, 1711279260, 1107299484, 335546380, 805325852, 1644743704, 101246984, 1611162772, 1610647584, 1141394444, 67161216, 1375790248, 1107861536, 268984508, 638094472);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_or_wide_wide()
        {
            int4x4 a0 = int4x4(1731159103, 659068416, 382702471, 1821032196, 1565773438, 1004000514, 948501377, 600951835, 669346222, 396691477, 2108560248, 2117522137, 330307355, 818676817, 1774459567, 1117506257);
            int4x4 b0 = int4x4(1583847161, 692672727, 1161585489, 1756207130, 1321374429, 1287357212, 2075767170, 1273513430, 1610830169, 1316929125, 511625048, 573925879, 1502255628, 1841676448, 1682928938, 1115131952);
            int4x4 r0 = int4x4(2138044159, 793370327, 1476391895, 1823457054, 1607720703, 2147473182, 2075786115, 1811533279, 1743223295, 1610595957, 2147407736, 2117598207, 1538957087, 2110637297, 1842315183, 1124063985);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(1254511182, 1017865993, 1883021644, 1140203470, 759288967, 2122744307, 335621148, 715028074, 543305337, 662107399, 1934997335, 436754869, 1613808671, 362365372, 342908672, 2129231210);
            int4x4 b1 = int4x4(1541423910, 1416096228, 188606371, 1041599540, 219545389, 560097663, 1087543661, 936383841, 108816721, 1694053551, 452638547, 1219534055, 85142537, 1027930490, 2126839395, 2030328147);
            int4x4 r1 = int4x4(1541821294, 2096099309, 2067654639, 2146934782, 760610735, 2145839615, 1423162749, 1071544171, 645820281, 1744827823, 2080356183, 1522064887, 1697901599, 1037957630, 2129985379, 2146270587);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(203868172, 32846030, 1057901177, 1537975433, 470626699, 557640158, 536364388, 238304731, 787227554, 1298371111, 1020821539, 1327618264, 1104669041, 1949771204, 1973724646, 698690868);
            int4x4 b2 = int4x4(2036352209, 1554561114, 1332339254, 480739851, 1502575584, 1889014859, 1557424474, 1390247341, 2029776623, 1665642846, 1570936353, 801872635, 1945815585, 1797879107, 112272980, 779933219);
            int4x4 r2 = int4x4(2103889117, 1576909022, 2138040959, 1605346955, 1569684459, 1908211167, 1610378622, 1593671167, 2130702319, 1869067135, 2113574435, 1877727995, 1946151793, 2134865351, 2008393718, 805175095);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(237797826, 356229491, 1054697631, 2025966311, 718324935, 1223426852, 2042482036, 683169667, 1994321453, 240702936, 828468284, 1009506608, 708733945, 449892073, 1530051697, 654498852);
            int4x4 b3 = int4x4(92416160, 446752586, 1307950607, 1358449730, 181367548, 432421751, 695223657, 56384197, 1119601678, 460615696, 463588364, 780415466, 1378457042, 1259569239, 1887579973, 358353719);
            int4x4 r3 = int4x4(263104994, 532408187, 2147352223, 2029637351, 719320831, 1508785015, 2046676349, 737959879, 1996484143, 528283096, 1004661820, 1051720186, 2051014651, 1540607743, 2075311989, 928964407);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_or_wide_scalar()
        {
            int4x4 a0 = int4x4(961259683, 471103264, 1733389229, 1591585258, 386953869, 1148351449, 1048929715, 1814263250, 860336789, 1637162093, 1227888278, 774029856, 879300408, 1179087439, 797240690, 1977614655);
            int b0 = (1666102508);
            int4x4 r0 = int4x4(2068823279, 2136930284, 1734344685, 2145369582, 2002712301, 1736374269, 2144335359, 1869608446, 1934604029, 1675607277, 1803466494, 1869543148, 2003812348, 1733293807, 1875836414, 2012132863);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(46921989, 284225881, 64304104, 313591807, 1393862490, 1890090886, 521303722, 2021379070, 2055963359, 1511253082, 1775629833, 1142751163, 1767274359, 1421981808, 1501294791, 485944015);
            int b1 = (1980838747);
            int4x4 r1 = int4x4(1994128223, 1995567963, 2010461179, 1991325695, 1997911899, 1991868383, 2131982331, 2122054655, 2124133343, 2115237723, 2144728923, 1981677563, 2136438655, 1993456507, 2138829791, 2130181087);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(539526284, 1815369493, 529427586, 358352200, 1353013374, 1349149982, 1624839772, 1369983151, 666444298, 207757238, 257316089, 409252967, 1919967661, 1452040383, 2012115244, 1149949643);
            int b2 = (310877895);
            int4x4 r2 = int4x4(850370255, 2125979607, 529530567, 400531407, 1386733311, 1391460319, 1927257823, 1404034799, 935313103, 518496247, 534241023, 451395303, 1928855535, 1452277503, 2012217327, 1452269263);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(142082352, 1052987078, 1551897284, 647667876, 272240018, 728496025, 1212085507, 1717689835, 478474157, 1784582014, 1420783529, 671512087, 1240546077, 215180285, 1874077134, 288085841);
            int b3 = (1760023655);
            int4x4 r3 = int4x4(1761596791, 2129125095, 2095568615, 1862268135, 2030034423, 1810888703, 1761604967, 1860689391, 2095579119, 1795153791, 2096103407, 1760032375, 1777860479, 1828190207, 1878521327, 2045761399);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1213433101);
            int4x4 b0 = int4x4(1212928242, 1614462616, 936937728, 764766995, 306352095, 574719481, 1283571271, 2109131012, 979469710, 1348323481, 1407542578, 697517649, 1059093741, 627815046, 418822515, 83214352);
            int4x4 r0 = int4x4(1213978111, 1752940445, 2145094925, 1842867999, 1515425759, 1783858685, 1288945487, 2113391885, 2054391183, 1482673565, 1542972735, 1775486813, 2138308077, 1836824463, 1492630911, 1291306269);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (424663473);
            int4x4 b1 = int4x4(447949225, 527022375, 1947148461, 305251437, 1254601325, 1752329425, 1592402684, 1587055329, 1088734150, 298563808, 2052547661, 582843231, 656983670, 1944993640, 1081208038, 829763560);
            int4x4 r1 = int4x4(469760441, 527432119, 2102393277, 461364733, 1540357117, 2038431217, 1609563133, 1608506353, 1508891639, 433060337, 2069888509, 1006631935, 1064296439, 2079326201, 1501560311, 964689913);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (990961386);
            int4x4 b2 = int4x4(547309556, 1307122961, 263229121, 1518227598, 1098359242, 997941952, 1075751132, 996271847, 623986648, 1091787263, 1548400620, 2022447724, 433714471, 963197960, 1639565037, 1287986616);
            int4x4 r2 = int4x4(1000333310, 2147082235, 1068556011, 2071912174, 2071461866, 997981930, 2065628926, 997326575, 1060233210, 2064900095, 2136670190, 2073878254, 1004142575, 997850858, 2075778799, 2144722938);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1326199854);
            int4x4 b3 = int4x4(1949398395, 2027606165, 1750615303, 908181664, 2105810564, 2009616838, 1492018691, 1325195313, 1365101592, 276155673, 1378507257, 1526287781, 322486040, 1550813488, 326334540, 2015237736);
            int4x4 r3 = int4x4(2134734207, 2145318079, 1868330287, 2133718190, 2139897518, 2144105966, 1609463343, 1341977663, 1599994942, 1602092351, 1596882431, 1610448303, 1597816638, 1601158462, 1602190446, 2132686446);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_xor_wide_wide()
        {
            int4x4 a0 = int4x4(1556324760, 207002929, 1843444873, 1632079131, 1460334334, 1607815585, 220623650, 38668553, 47193340, 643663548, 1371932564, 94957188, 700973621, 370621508, 2087573076, 351476570);
            int4x4 b0 = int4x4(1054997548, 1523759632, 251164872, 110472397, 384031112, 1109163205, 535118981, 179106262, 1523031711, 1713313372, 1294118730, 520360641, 1040688781, 1020757245, 1143954843, 1281933464);
            int4x4 r0 = int4x4(1646419380, 1451501345, 1662567489, 1741824470, 1105803126, 499723620, 314783655, 149092575, 1477935715, 1078104288, 484747486, 447544389, 399484088, 717273273, 943885263, 1486609346);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(1340815927, 681577472, 314138777, 446857644, 1368661599, 1672499683, 1259759761, 2049102405, 1972524935, 91962333, 1960780785, 1303778459, 960040360, 822786011, 2028027011, 170382968);
            int4x4 b1 = int4x4(175288469, 326874157, 1192052687, 1087083643, 1900865484, 1521193463, 569695524, 1622101483, 1340735463, 546583617, 1034420616, 262206030, 1834125935, 802756092, 611321886, 316379491);
            int4x4 r1 = int4x4(1167690402, 1004255277, 1437869910, 1516836311, 551090579, 958119956, 1793242549, 445489070, 981182560, 636424092, 1232544377, 1108797141, 1416333255, 517186087, 1553020061, 419186459);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(32554542, 1915830925, 2001025156, 2012451132, 1076174067, 344651773, 1769102694, 1408084527, 1139070023, 1195715957, 1051992510, 1468636326, 1018993657, 1514317444, 369266676, 1206540279);
            int4x4 b2 = int4x4(325882121, 45335181, 1859278043, 1002624300, 1704063552, 1618550727, 721247372, 131278097, 896003672, 746837613, 1952376600, 306395311, 419371442, 627496489, 1791585199, 757339713);
            int4x4 r2 = int4x4(312225575, 1887600640, 429354079, 1278297104, 632614579, 1962141754, 1133445610, 1413386046, 1988311583, 1808202520, 1256900262, 1170908169, 608404043, 2133094573, 2093737051, 1791902134);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(1730482516, 1488638921, 801348246, 1768559974, 1475767978, 1617893197, 689768843, 640586983, 426041408, 1811169716, 1563089576, 1411870628, 1004729442, 1173825171, 344960599, 633357624);
            int4x4 b3 = int4x4(1356120192, 933877640, 2003767224, 113246892, 1236821680, 256717233, 1832711379, 238792988, 691507914, 1132023339, 1571029002, 227661589, 1609435614, 1581653714, 1384954643, 1432072515);
            int4x4 r3 = int4x4(938594772, 1863517249, 1487705390, 1873418186, 508430362, 1864509180, 1143078232, 672474619, 810775178, 680333215, 9362082, 1505147057, 1678572988, 464599105, 1174607172, 1889268859);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_xor_wide_scalar()
        {
            int4x4 a0 = int4x4(2124666952, 177397845, 574879617, 1937385541, 1136545648, 213863690, 535061373, 289301586, 1305234431, 353786540, 1308626970, 1267729267, 125659640, 1315625690, 1730088797, 116862046);
            int b0 = (493665894);
            int4x4 r0 = int4x4(1674536494, 402546227, 1060063719, 1846973987, 1590882582, 299103084, 42523931, 206756404, 1352725913, 142271690, 1399631484, 1459404053, 437376926, 1392927932, 2054402363, 463180344);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(375757978, 191750702, 187129429, 967051293, 549951551, 653124416, 788984, 1479174924, 1680011736, 447453839, 890841598, 293394300, 527727631, 529042816, 1382138962, 1206186973);
            int b1 = (491079274);
            int4x4 r1 = int4x4(186702576, 371762244, 375527487, 618745463, 1031986773, 1000908074, 491343762, 1164914022, 2036840370, 133094629, 677146516, 205099286, 36780645, 47041514, 1327792696, 1520547255);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(1059509471, 64097148, 1814786305, 716239, 476052372, 92561487, 2058208914, 41260658, 1316660543, 2113008061, 256229982, 111578612, 1207271814, 2099944258, 1913013312, 870798185);
            int b2 = (744733291);
            int4x4 r2 = int4x4(323317428, 800174359, 1078512490, 745101220, 809255423, 703060516, 1456372985, 773205017, 1645813588, 1368542166, 589723701, 717567903, 1805007853, 1363747113, 1583742507, 528804098);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(1771744425, 1026064492, 275465401, 1157615659, 2091197990, 1671757076, 574090633, 458210617, 1604017559, 1913893498, 1791703422, 2143390933, 777506800, 1972227371, 2073971655, 61542294);
            int b3 = (75727457);
            int4x4 r3 = int4x4(1830366920, 967508493, 350799576, 1081889354, 2015798343, 1730641781, 649359336, 533479256, 1528356854, 1989160987, 1850260255, 2067926708, 718556561, 1896763210, 2132658598, 120098295);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1288453276);
            int4x4 b0 = int4x4(1077599928, 884741329, 212164516, 1585020328, 152985454, 1775851275, 1416249064, 1309317737, 1773918217, 1509843030, 1206045972, 1154916424, 1947871003, 1774252400, 1946113778, 1079717492);
            int4x4 r0 = int4x4(217506340, 2020616269, 1080648504, 313868596, 1171416050, 622160791, 413532788, 46573301, 628614293, 355622090, 187625864, 135961812, 953555847, 621596140, 1060334190, 211227368);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (290620937);
            int4x4 b1 = int4x4(1382343363, 939045099, 1309568053, 221134131, 885841718, 612068188, 194068085, 1396957881, 573581481, 1813817520, 86594349, 2006985393, 1431761813, 905646837, 1522414781, 192882943);
            int4x4 r1 = int4x4(1127638218, 648689378, 1599924796, 477936442, 631134527, 891940181, 449034364, 1108436144, 862105248, 2102275769, 343659812, 1727179960, 1141142940, 615093500, 1273803444, 439201526);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (714832744);
            int4x4 b2 = int4x4(374210759, 215701593, 1573378082, 779254615, 711527976, 710611783, 223429246, 593102399, 1444947259, 302938485, 684673240, 1417651941, 1426772271, 948720266, 177752267, 2005602645);
            int4x4 r2 = int4x4(1020623791, 641737521, 2002559818, 82378815, 15889728, 12609583, 667564310, 163675479, 2092654163, 949289501, 39072688, 2128928141, 2140252743, 303507938, 537080739, 1561356861);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (896851285);
            int4x4 b3 = int4x4(1187420887, 536338211, 874727301, 1067319145, 191758210, 272673141, 18096431, 188062447, 1726887620, 2109517402, 1329654715, 1449815991, 342156404, 604196193, 1831114838, 962033481);
            int4x4 r3 = int4x4(1941063554, 713228918, 22518480, 183050812, 1041834711, 624194592, 878771322, 1044465594, 1402661777, 1221096207, 2050242286, 1662956258, 554711329, 293048372, 1481655555, 203663900);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_left_shift()
        {
            int4x4 a0 = int4x4(197771193, 622182602, 1283988958, 1327917304, 473415985, 432425717, 870301196, 2058433484, 1200694230, 1531607705, 1360008038, 1008296534, 1447702302, 1079614371, 35667343, 1664454606);
            int b0 = (1321149625);
            int4x4 r0 = int4x4(1912602624, -1811939328, -1140850688, -268435456, 1644167168, -369098752, 402653184, -1744830464, -1409286144, 838860800, -872415232, -1409286144, 1006632960, 1174405120, 503316480, -1677721600);
            TestUtils.AreEqual(a0 << b0, r0);

            int4x4 a1 = int4x4(2045594989, 592678686, 297755411, 1722762487, 1161625759, 37265945, 997793693, 1521705181, 263886278, 221147365, 2084190583, 230910816, 71403448, 481375728, 1176038816, 1382694875);
            int b1 = (2077023268);
            int4x4 r1 = int4x4(-1630218544, 892924384, 469119280, 1794396016, 1406142960, 596255120, -1215170096, -1422520880, -72786848, -756609456, -1012689040, -600394240, 1142455168, -887922944, 1636751872, 648281520);
            TestUtils.AreEqual(a1 << b1, r1);

            int4x4 a2 = int4x4(1824729613, 1581610518, 407677878, 1208958192, 740058147, 946058001, 880835937, 2063772405, 430594634, 281771991, 1130057990, 1127968177, 1628217625, 979935914, 17663275, 956738326);
            int b2 = (1535276688);
            int4x4 r2 = int4x4(705495040, 1981153280, -1414135808, 1022361600, 1680015360, -1290731520, 2103508992, -1426784256, 1514799104, 2144796672, 1359347712, 1840316416, -1592197120, -1565917184, -2060779520, -1424621568);
            TestUtils.AreEqual(a2 << b2, r2);

            int4x4 a3 = int4x4(1996060114, 542942787, 65869628, 622492353, 159523866, 584916657, 286195265, 1953695770, 209529707, 211278352, 933594260, 1827522668, 1129290782, 1050231977, 183969222, 1773085306);
            int b3 = (927390277);
            int4x4 r3 = int4x4(-550585792, 194300000, 2107828096, -1555081184, 809796416, 1537463840, 568313888, -1906244800, -1884983968, -1829027328, -189754752, -1648816768, 1777566656, -752315104, 1592047808, 904154944);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_right_shift()
        {
            int4x4 a0 = int4x4(548167301, 1161338299, 1617625829, 1860731847, 713958715, 196552656, 770466193, 1265099998, 572763124, 506619530, 426807581, 2031319045, 701927980, 917785020, 569504877, 185593382);
            int b0 = (1266801540);
            int4x4 r0 = int4x4(34260456, 72583643, 101101614, 116295740, 44622419, 12284541, 48154137, 79068749, 35797695, 31663720, 26675473, 126957440, 43870498, 57361563, 35594054, 11599586);
            TestUtils.AreEqual(a0 >> b0, r0);

            int4x4 a1 = int4x4(1102123711, 1624751550, 280138733, 1598620011, 1840564178, 736389149, 1279158873, 408822762, 763607760, 348013684, 1568185874, 774126687, 1587054000, 600069797, 29576474, 1880981389);
            int b1 = (334005460);
            int4x4 r1 = int4x4(1051, 1549, 267, 1524, 1755, 702, 1219, 389, 728, 331, 1495, 738, 1513, 572, 28, 1793);
            TestUtils.AreEqual(a1 >> b1, r1);

            int4x4 a2 = int4x4(352174824, 425441430, 186542511, 1099859381, 1234295294, 1028666766, 761662151, 1254855819, 903402043, 1180315725, 182990778, 958706431, 1075621082, 1409488892, 1576738052, 700893981);
            int b2 = (1164508476);
            int4x4 r2 = int4x4(1, 1, 0, 4, 4, 3, 2, 4, 3, 4, 0, 3, 4, 5, 5, 2);
            TestUtils.AreEqual(a2 >> b2, r2);

            int4x4 a3 = int4x4(1435331003, 1447204571, 494777716, 1097030937, 1573721009, 424949150, 338466956, 1451909085, 2097834602, 1996022619, 1349763966, 490973311, 1133192771, 2054033380, 397231107, 150337656);
            int b3 = (1759616654);
            int4x4 r3 = int4x4(87605, 88330, 30198, 66957, 96052, 25936, 20658, 88617, 128041, 121827, 82383, 29966, 69164, 125368, 24245, 9175);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void int4x4_operator_bitwise_not()
        {
            int4x4 a0 = int4x4(1403358969, 831360921, 2088190243, 976721016, 878283189, 308994339, 1935567517, 1420884856, 472965491, 771711426, 627580960, 2061524024, 753208488, 2097179283, 1303022493, 664744603);
            int4x4 r0 = int4x4(-1403358970, -831360922, -2088190244, -976721017, -878283190, -308994340, -1935567518, -1420884857, -472965492, -771711427, -627580961, -2061524025, -753208489, -2097179284, -1303022494, -664744604);
            TestUtils.AreEqual(~a0, r0);

            int4x4 a1 = int4x4(1289372466, 1951018596, 1545651937, 717936457, 1284504687, 1342785385, 869629475, 2045854321, 1282546942, 1562433528, 1824824810, 1736570715, 508906058, 2060752880, 1867418756, 388530274);
            int4x4 r1 = int4x4(-1289372467, -1951018597, -1545651938, -717936458, -1284504688, -1342785386, -869629476, -2045854322, -1282546943, -1562433529, -1824824811, -1736570716, -508906059, -2060752881, -1867418757, -388530275);
            TestUtils.AreEqual(~a1, r1);

            int4x4 a2 = int4x4(695179852, 897923626, 1816190464, 1362906829, 1227946838, 700158434, 189609278, 956441808, 2123488810, 1593014251, 19223061, 1722107954, 1636875694, 1914097392, 1382545027, 1285277010);
            int4x4 r2 = int4x4(-695179853, -897923627, -1816190465, -1362906830, -1227946839, -700158435, -189609279, -956441809, -2123488811, -1593014252, -19223062, -1722107955, -1636875695, -1914097393, -1382545028, -1285277011);
            TestUtils.AreEqual(~a2, r2);

            int4x4 a3 = int4x4(722020848, 183545104, 2006881282, 685422512, 70717710, 1636059183, 1218560768, 1078350342, 1743219894, 894044458, 110742707, 1831797788, 2111543080, 858442193, 907645851, 1672993750);
            int4x4 r3 = int4x4(-722020849, -183545105, -2006881283, -685422513, -70717711, -1636059184, -1218560769, -1078350343, -1743219895, -894044459, -110742708, -1831797789, -2111543081, -858442194, -907645852, -1672993751);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
