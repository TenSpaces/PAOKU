// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3
    {
        [TestCompiler]
        public static void float3_zero()
        {
            TestUtils.AreEqual(float3.zero.x, 0.0f);
            TestUtils.AreEqual(float3.zero.y, 0.0f);
            TestUtils.AreEqual(float3.zero.z, 0.0f);
        }

        [TestCompiler]
        public static void float3_constructor()
        {
            float3 a = new float3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void float3_scalar_constructor()
        {
            float3 a = new float3(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
            TestUtils.AreEqual(a.z, 17.0f);
        }

        [TestCompiler]
        public static void float3_static_constructor()
        {
            float3 a = float3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void float3_static_scalar_constructor()
        {
            float3 a = float3(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
            TestUtils.AreEqual(a.z, 17.0f);
        }

        [TestCompiler]
        public static void float3_operator_equal_wide_wide()
        {
            float3 a0 = float3(-135.18924f, -49.0941162f, 169.129822f);
            float3 b0 = float3(-220.014648f, 66.98004f, 499.2016f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3 a1 = float3(240.8053f, 314.7392f, 442.393f);
            float3 b1 = float3(-371.1131f, 208.448669f, 390.8037f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3 a2 = float3(177.924438f, 335.5334f, 168.15448f);
            float3 b2 = float3(-72.44382f, 362.97644f, 194.678345f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3 a3 = float3(350.729553f, 367.178467f, 46.9414673f);
            float3 b3 = float3(471.644836f, -404.044678f, -144.696747f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_equal_wide_scalar()
        {
            float3 a0 = float3(65.6712f, 404.415527f, -269.730164f);
            float b0 = (-155.815765f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3 a1 = float3(83.6306152f, -155.868286f, 314.671265f);
            float b1 = (152.9945f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3 a2 = float3(386.365173f, -132.6352f, -65.66748f);
            float b2 = (290.04895f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3 a3 = float3(-69.68326f, 186.845215f, -232.895691f);
            float b3 = (-191.190765f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float3 b0 = float3(-400.4892f, -71.2868347f, 156.978088f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-225.238739f);
            float3 b1 = float3(499.141785f, -211.979919f, 428.311951f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-489.501343f);
            float3 b2 = float3(-5.691559f, -30.8659363f, -362.9831f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (184.503174f);
            float3 b3 = float3(-160.470612f, 316.668823f, 390.369263f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_not_equal_wide_wide()
        {
            float3 a0 = float3(279.994141f, -43.34201f, -465.724731f);
            float3 b0 = float3(-460.9121f, -476.009033f, 468.1364f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3 a1 = float3(317.466553f, 85.7149658f, 360.8905f);
            float3 b1 = float3(-341.012543f, -62.65805f, -458.801666f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3 a2 = float3(366.081543f, 154.542847f, 332.4262f);
            float3 b2 = float3(-457.730225f, -59.5232544f, 3.024231f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3 a3 = float3(397.11322f, -431.374969f, 489.0108f);
            float3 b3 = float3(155.812744f, -19.8399048f, -6.01693726f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_not_equal_wide_scalar()
        {
            float3 a0 = float3(-155.4411f, -19.4266052f, 174.633057f);
            float b0 = (-393.413544f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3 a1 = float3(507.920715f, 171.151489f, -58.92328f);
            float b1 = (59.177063f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3 a2 = float3(-398.176849f, -165.241516f, 270.341f);
            float b2 = (492.20105f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3 a3 = float3(-380.243256f, -134.345459f, 458.400452f);
            float b3 = (501.899048f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float3 b0 = float3(459.553223f, 436.453247f, -488.714172f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (392.767944f);
            float3 b1 = float3(-266.736633f, 338.557861f, -338.100128f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-152.314545f);
            float3 b2 = float3(-452.820679f, 209.439331f, 50.10797f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (372.4344f);
            float3 b3 = float3(-488.0213f, 489.740784f, 270.4001f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_wide_wide()
        {
            float3 a0 = float3(51.7102661f, -313.85556f, 283.047668f);
            float3 b0 = float3(-261.835236f, -19.81073f, -149.25882f);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float3 a1 = float3(235.021912f, 44.07837f, -207.255676f);
            float3 b1 = float3(205.99823f, -306.024384f, 102.121704f);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3 a2 = float3(3.38293457f, -144.301331f, -69.3696f);
            float3 b2 = float3(231.906311f, 179.49884f, 473.2249f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float3 a3 = float3(-135.667969f, -194.787354f, -33.473877f);
            float3 b3 = float3(15.8916626f, 270.049927f, 490.914f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_wide_scalar()
        {
            float3 a0 = float3(-221.869781f, -121.546478f, -97.5239258f);
            float b0 = (199.0675f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3 a1 = float3(479.8811f, 137.3288f, 282.9666f);
            float b1 = (67.11902f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float3 a2 = float3(258.2791f, -288.081116f, 82.6654053f);
            float b2 = (-111.413147f);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3 a3 = float3(-361.6429f, 12.7880249f, -66.703064f);
            float b3 = (-68.0881958f);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float3 b0 = float3(-377.196533f, -505.147552f, 375.9267f);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (110.17395f);
            float3 b1 = float3(-118.097565f, -40.4508972f, -299.744324f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (31.4371338f);
            float3 b2 = float3(-458.904541f, 13.6846924f, -458.5069f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (248.276489f);
            float3 b3 = float3(389.231445f, 488.745544f, -221.637878f);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_wide_wide()
        {
            float3 a0 = float3(-229.29068f, 505.536621f, -73.80707f);
            float3 b0 = float3(-445.845032f, -420.035278f, 299.0244f);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float3 a1 = float3(100.292053f, -419.214783f, -159.559753f);
            float3 b1 = float3(-13.8809814f, 151.5617f, -163.50943f);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3 a2 = float3(-396.770355f, 127.037415f, 489.1399f);
            float3 b2 = float3(-391.096039f, 479.283752f, -77.6748657f);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float3 a3 = float3(51.9188843f, 155.384766f, -135.631653f);
            float3 b3 = float3(-46.584198f, -415.377f, 71.46698f);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_wide_scalar()
        {
            float3 a0 = float3(11.156311f, -411.023224f, 385.885559f);
            float b0 = (-302.816956f);
            bool3 r0 = bool3(true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3 a1 = float3(-485.103058f, 405.175354f, 173.575073f);
            float b1 = (-491.180023f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3 a2 = float3(69.26929f, -367.027771f, -86.12451f);
            float b2 = (501.306824f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3 a3 = float3(-489.090576f, -18.1496277f, -236.414948f);
            float b3 = (-172.518158f);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float3 b0 = float3(-226.2044f, -423.465f, 409.405518f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (453.877075f);
            float3 b1 = float3(87.47571f, 113.795593f, 176.409241f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-140.440033f);
            float3 b2 = float3(-182.48288f, -158.2933f, -162.685333f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-193.328674f);
            float3 b3 = float3(230.181274f, -102.58783f, 392.520569f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_equal_wide_wide()
        {
            float3 a0 = float3(240.090515f, 462.213135f, 293.08252f);
            float3 b0 = float3(-81.20383f, 493.637451f, -411.4721f);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3 a1 = float3(-427.870667f, -405.5227f, 204.591919f);
            float3 b1 = float3(99.16443f, -295.6677f, -480.462555f);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3 a2 = float3(294.6701f, -327.564453f, -456.12326f);
            float3 b2 = float3(74.41406f, 260.916138f, 306.173279f);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3 a3 = float3(282.30127f, 421.881165f, -311.71283f);
            float3 b3 = float3(139.564819f, -505.752472f, -489.6268f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_equal_wide_scalar()
        {
            float3 a0 = float3(309.192444f, 69.67377f, -101.724182f);
            float b0 = (292.924255f);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3 a1 = float3(-315.9724f, 424.15387f, -410.870056f);
            float b1 = (-346.011047f);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3 a2 = float3(-483.902649f, 320.4425f, -257.870056f);
            float b2 = (183.821167f);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3 a3 = float3(-386.801758f, 349.250122f, 485.311584f);
            float b3 = (-182.938812f);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float3 b0 = float3(51.1589966f, 340.443665f, 312.81427f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (354.1925f);
            float3 b1 = float3(136.396729f, -94.76788f, 288.5443f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (304.042847f);
            float3 b2 = float3(-148.618073f, -506.3001f, 27.5812378f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (48.47113f);
            float3 b3 = float3(104.883484f, -488.685852f, -480.435181f);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_equal_wide_wide()
        {
            float3 a0 = float3(-386.5918f, -157.120789f, 391.015259f);
            float3 b0 = float3(153.443f, 49.8924561f, 78.02582f);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3 a1 = float3(-511.886871f, -5.42202759f, 287.645264f);
            float3 b1 = float3(138.813721f, -225.51059f, -339.3561f);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3 a2 = float3(-122.535187f, 7.48144531f, 152.946411f);
            float3 b2 = float3(-373.302063f, 364.9359f, -322.7154f);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3 a3 = float3(48.9862061f, 57.3381348f, 300.4649f);
            float3 b3 = float3(125.47821f, -25.77658f, 297.518921f);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_equal_wide_scalar()
        {
            float3 a0 = float3(495.4574f, -14.3451233f, -463.4748f);
            float b0 = (189.205139f);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3 a1 = float3(217.517517f, -377.6587f, 53.8151245f);
            float b1 = (-246.865723f);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3 a2 = float3(-123.332947f, 252.994324f, -116.440369f);
            float b2 = (-221.505463f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3 a3 = float3(-395.3633f, -287.007324f, 355.837036f);
            float b3 = (164.772583f);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float3 b0 = float3(204.802979f, -101.104034f, -122.055023f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-70.45615f);
            float3 b1 = float3(-239.62027f, -185.992737f, -455.612579f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (276.665833f);
            float3 b2 = float3(79.39917f, 416.420532f, 379.2735f);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-439.5147f);
            float3 b3 = float3(67.14099f, -74.56064f, -367.256348f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_add_wide_wide()
        {
            float3 a0 = float3(465.148376f, 278.9107f, -277.5299f);
            float3 b0 = float3(483.9944f, -204.07666f, -365.673553f);
            float3 r0 = float3(949.142761f, 74.8340454f, -643.2035f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3 a1 = float3(-65.1972046f, -473.324371f, -4.69555664f);
            float3 b1 = float3(-509.920868f, -270.6975f, 486.763977f);
            float3 r1 = float3(-575.118042f, -744.021851f, 482.06842f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3 a2 = float3(-470.536774f, -109.9501f, -178.701447f);
            float3 b2 = float3(267.49176f, 251.642517f, 244.495117f);
            float3 r2 = float3(-203.045013f, 141.692413f, 65.79367f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3 a3 = float3(-420.033783f, 290.711121f, -446.529633f);
            float3 b3 = float3(-78.67575f, 352.2055f, 82.7791748f);
            float3 r3 = float3(-498.709534f, 642.9166f, -363.750458f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_add_wide_scalar()
        {
            float3 a0 = float3(459.898315f, -447.663361f, -94.43863f);
            float b0 = (500.997253f);
            float3 r0 = float3(960.895569f, 53.3338928f, 406.558624f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3 a1 = float3(126.429871f, -349.6413f, -2.79125977f);
            float b1 = (-36.254364f);
            float3 r1 = float3(90.17551f, -385.89566f, -39.0456238f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3 a2 = float3(-478.4148f, 268.092224f, 41.3210449f);
            float b2 = (443.115234f);
            float3 r2 = float3(-35.29956f, 711.207458f, 484.436279f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3 a3 = float3(-471.256073f, 78.98584f, 202.14801f);
            float b3 = (-2.664978f);
            float3 r3 = float3(-473.921051f, 76.32086f, 199.483032f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float3 b0 = float3(-264.088135f, -106.009247f, -355.4473f);
            float3 r0 = float3(-589.6009f, -431.522f, -680.9601f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-447.3303f);
            float3 b1 = float3(-158.7002f, -199.4837f, 180.318115f);
            float3 r1 = float3(-606.0305f, -646.813965f, -267.012177f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (337.579346f);
            float3 b2 = float3(-37.0550232f, 230.805f, -140.174347f);
            float3 r2 = float3(300.524323f, 568.384338f, 197.405f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (18.02417f);
            float3 b3 = float3(-138.614349f, 26.9041748f, -374.5376f);
            float3 r3 = float3(-120.590179f, 44.9283447f, -356.513428f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_sub_wide_wide()
        {
            float3 a0 = float3(133.371033f, -131.832123f, -197.293152f);
            float3 b0 = float3(123.460266f, 359.56012f, -48.2484741f);
            float3 r0 = float3(9.910767f, -491.392242f, -149.044678f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3 a1 = float3(-485.28656f, -337.550323f, 471.6671f);
            float3 b1 = float3(478.979065f, 207.158325f, 142.36731f);
            float3 r1 = float3(-964.2656f, -544.7086f, 329.2998f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3 a2 = float3(146.506592f, -130.585052f, 110.7771f);
            float3 b2 = float3(-125.6055f, -65.29901f, -477.876434f);
            float3 r2 = float3(272.1121f, -65.28604f, 588.653564f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3 a3 = float3(-235.5416f, 78.87933f, -347.686157f);
            float3 b3 = float3(164.5f, 428.009583f, 72.62781f);
            float3 r3 = float3(-400.0416f, -349.130249f, -420.313965f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_sub_wide_scalar()
        {
            float3 a0 = float3(48.9367065f, 410.4516f, -364.4417f);
            float b0 = (-291.5904f);
            float3 r0 = float3(340.5271f, 702.042f, -72.85132f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3 a1 = float3(163.980591f, 110.919434f, 204.358337f);
            float b1 = (-460.067322f);
            float3 r1 = float3(624.0479f, 570.986755f, 664.425659f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3 a2 = float3(180.269714f, -470.262054f, 400.5349f);
            float b2 = (-377.9257f);
            float3 r2 = float3(558.195435f, -92.3363647f, 778.4606f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3 a3 = float3(461.507568f, 21.6052856f, 246.350708f);
            float b3 = (-246.287262f);
            float3 r3 = float3(707.7948f, 267.892548f, 492.63797f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float3 b0 = float3(452.352539f, 256.9898f, -275.159882f);
            float3 r0 = float3(-157.766052f, 37.59668f, 569.746338f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-89.02753f);
            float3 b1 = float3(488.2284f, -333.2173f, -64.233f);
            float3 r1 = float3(-577.2559f, 244.189758f, -24.7945251f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-66.04172f);
            float3 b2 = float3(341.204956f, -385.775055f, 75.3947754f);
            float3 r2 = float3(-407.246674f, 319.733337f, -141.4365f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (354.943726f);
            float3 b3 = float3(169.131409f, 88.21661f, 1.73498535f);
            float3 r3 = float3(185.812317f, 266.7271f, 353.20874f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mul_wide_wide()
        {
            float3 a0 = float3(-394.780548f, -412.3722f, -25.8745728f);
            float3 b0 = float3(-149.763977f, -345.04538f, -284.334045f);
            float3 r0 = float3(59123.9063f, 142287.125f, 7357.022f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3 a1 = float3(-241.045959f, -93.6759949f, 244.159973f);
            float3 b1 = float3(267.979248f, -326.6485f, -150.689667f);
            float3 r1 = float3(-64595.3164f, 30599.123f, -36792.3867f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3 a2 = float3(494.688477f, 53.5379639f, -239.4964f);
            float3 b2 = float3(207.732422f, 366.192871f, 358.880737f);
            float3 r2 = float3(102762.836f, 19605.22f, -85950.64f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3 a3 = float3(236.675842f, -211.8562f, -216.654816f);
            float3 b3 = float3(214.853577f, 253.422791f, -307.7138f);
            float3 r3 = float3(50850.6523f, -53689.19f, 66667.68f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mul_wide_scalar()
        {
            float3 a0 = float3(328.203f, -290.10672f, 236.995728f);
            float b0 = (192.211182f);
            float3 r0 = float3(63084.2852f, -55761.7539f, 45553.23f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3 a1 = float3(120.481384f, 134.867249f, -477.3105f);
            float b1 = (357.903137f);
            float3 r1 = float3(43120.6641f, 48269.41f, -170830.922f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3 a2 = float3(-438.272919f, -238.405f, 422.08252f);
            float b2 = (-46.729187f);
            float3 r2 = float3(20480.1367f, 11140.4717f, -19723.5723f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3 a3 = float3(-48.83484f, 119.356628f, -196.995819f);
            float b3 = (355.30835f);
            float3 r3 = float3(-17351.4258f, 42408.4063f, -69994.26f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float3 b0 = float3(329.360962f, -198.683441f, 184.0794f);
            float3 r0 = float3(-152999.6f, 92295.35f, -85511.27f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (256.016174f);
            float3 b1 = float3(266.226318f, -97.8947449f, 159.748108f);
            float3 r1 = float3(68158.24f, -25062.6387f, 40898.0977f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-351.8222f);
            float3 b2 = float3(491.801575f, 49.90204f, 424.4626f);
            float3 r2 = float3(-173026.719f, -17556.6445f, -149335.359f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (160.1181f);
            float3 b3 = float3(-395.9921f, 125.20166f, -265.0158f);
            float3 r3 = float3(-63405.5039f, 20047.0527f, -42433.83f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_div_wide_wide()
        {
            float3 a0 = float3(246.265747f, -269.85614f, -451.619537f);
            float3 b0 = float3(172.119812f, -77.14111f, -325.8354f);
            float3 r0 = float3(1.43078089f, 3.49821424f, 1.38603592f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3 a1 = float3(-7.388489f, -308.205566f, -373.3948f);
            float3 b1 = float3(-450.608673f, -261.262146f, -122.449493f);
            float3 r1 = float3(0.0163966864f, 1.17967939f, 3.04937816f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3 a2 = float3(360.41864f, 25.8097534f, -274.050476f);
            float3 b2 = float3(-93.2107849f, -442.005219f, 484.362732f);
            float3 r2 = float3(-3.86670542f, -0.0583924167f, -0.565795958f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3 a3 = float3(127.538574f, -447.671753f, -137.458588f);
            float3 b3 = float3(-390.7818f, 402.02533f, 316.6507f);
            float3 r3 = float3(-0.326367736f, -1.11354113f, -0.434101641f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_div_wide_scalar()
        {
            float3 a0 = float3(-244.517456f, 69.1123047f, -333.023132f);
            float b0 = (-60.0243835f);
            float3 r0 = float3(4.07363558f, -1.15140378f, 5.548131f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3 a1 = float3(257.396851f, 154.34436f, 131.526611f);
            float b1 = (403.2456f);
            float3 r1 = float3(0.6383129f, 0.38275522f, 0.326169968f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3 a2 = float3(-261.8864f, -275.5387f, 210.557922f);
            float b2 = (-348.9238f);
            float3 r2 = float3(0.75055474f, 0.789681554f, -0.6034496f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3 a3 = float3(287.6424f, 491.7871f, -26.6315918f);
            float b3 = (504.372253f);
            float3 r3 = float3(0.570297837f, 0.9750479f, -0.05280146f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float3 b0 = float3(-422.676147f, 248.129639f, 449.391357f);
            float3 r0 = float3(-0.09874622f, 0.168209136f, 0.0928759947f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (245.858154f);
            float3 b1 = float3(-326.6206f, 163.715088f, 333.6645f);
            float3 r1 = float3(-0.7527331f, 1.501744f, 0.736842453f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (38.2910767f);
            float3 b2 = float3(-472.979767f, 192.230164f, -200.296875f);
            float3 r2 = float3(-0.0809571147f, 0.19919391f, -0.191171616f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-490.181519f);
            float3 b3 = float3(-211.10257f, -322.852356f, -137.985291f);
            float3 r3 = float3(2.32200646f, 1.51828384f, 3.55241871f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mod_wide_wide()
        {
            float3 a0 = float3(-442.309875f, 368.5005f, -1.09390259f);
            float3 b0 = float3(-43.2450562f, -144.195862f, -62.6404724f);
            float3 r0 = float3(-9.859314f, 80.1087646f, -1.09390259f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3 a1 = float3(-364.673828f, -197.343933f, -34.0349121f);
            float3 b1 = float3(-336.828247f, -154.61026f, -154.029358f);
            float3 r1 = float3(-27.8455811f, -42.7336731f, -34.0349121f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3 a2 = float3(-101.348572f, 208.318542f, -140.770325f);
            float3 b2 = float3(487.0462f, -469.8291f, -145.203766f);
            float3 r2 = float3(-101.348572f, 208.318542f, -140.770325f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3 a3 = float3(183.44696f, -463.368378f, 83.83911f);
            float3 b3 = float3(-203.384f, -22.52008f, 224.69f);
            float3 r3 = float3(183.44696f, -12.9667664f, 83.83911f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mod_wide_scalar()
        {
            float3 a0 = float3(-433.417f, -5.51412964f, 393.3944f);
            float b0 = (-90.49924f);
            float3 r0 = float3(-71.4200439f, -5.51412964f, 31.39746f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3 a1 = float3(299.41156f, -502.939026f, -450.807678f);
            float b1 = (-120.80603f);
            float3 r1 = float3(57.7995f, -19.7149048f, -88.38959f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3 a2 = float3(186.094788f, -318.7815f, 433.4547f);
            float b2 = (-84.47363f);
            float3 r2 = float3(17.147522f, -65.3605957f, 11.0865479f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3 a3 = float3(-54.60019f, -429.714661f, 222.361877f);
            float b3 = (-172.338867f);
            float3 r3 = float3(-54.60019f, -85.03693f, 50.02301f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float3 b0 = float3(-159.140259f, 230.17334f, 14.7793579f);
            float3 r0 = float3(-78.14188f, -166.249054f, -12.1590881f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-303.1565f);
            float3 b1 = float3(399.635f, 206.6947f, 397.0448f);
            float3 r1 = float3(-303.1565f, -96.46179f, -303.1565f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-393.890656f);
            float3 b2 = float3(-372.067078f, 201.012268f, -95.566864f);
            float3 r2 = float3(-21.8235779f, -192.878387f, -11.6231995f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-258.951477f);
            float3 b3 = float3(106.983582f, 469.323547f, -34.80899f);
            float3 r3 = float3(-44.984314f, -258.951477f, -15.2885437f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3_operator_plus()
        {
            float3 a0 = float3(271.670837f, -79.08023f, -330.985046f);
            float3 r0 = float3(271.670837f, -79.08023f, -330.985046f);
            TestUtils.AreEqual(+a0, r0);

            float3 a1 = float3(31.824707f, 319.222168f, 190.324646f);
            float3 r1 = float3(31.824707f, 319.222168f, 190.324646f);
            TestUtils.AreEqual(+a1, r1);

            float3 a2 = float3(-350.3086f, 102.054382f, -107.00351f);
            float3 r2 = float3(-350.3086f, 102.054382f, -107.00351f);
            TestUtils.AreEqual(+a2, r2);

            float3 a3 = float3(-428.7762f, 234.773926f, 34.28363f);
            float3 r3 = float3(-428.7762f, 234.773926f, 34.28363f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float3_operator_neg()
        {
            float3 a0 = float3(420.227173f, -196.2575f, -335.426819f);
            float3 r0 = float3(-420.227173f, 196.2575f, 335.426819f);
            TestUtils.AreEqual(-a0, r0);

            float3 a1 = float3(509.04364f, -498.575317f, -495.837952f);
            float3 r1 = float3(-509.04364f, 498.575317f, 495.837952f);
            TestUtils.AreEqual(-a1, r1);

            float3 a2 = float3(-270.859467f, 268.2367f, -180.600525f);
            float3 r2 = float3(270.859467f, -268.2367f, 180.600525f);
            TestUtils.AreEqual(-a2, r2);

            float3 a3 = float3(223.381287f, -395.681549f, -349.149475f);
            float3 r3 = float3(-223.381287f, 395.681549f, 349.149475f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float3_operator_prefix_inc()
        {
            float3 a0 = float3(-99.79556f, 458.741821f, 96.1790161f);
            float3 r0 = float3(-98.79556f, 459.741821f, 97.1790161f);
            TestUtils.AreEqual(++a0, r0);

            float3 a1 = float3(-48.55246f, -299.230164f, -323.614868f);
            float3 r1 = float3(-47.55246f, -298.230164f, -322.614868f);
            TestUtils.AreEqual(++a1, r1);

            float3 a2 = float3(-456.8903f, -305.584778f, 64.0965f);
            float3 r2 = float3(-455.8903f, -304.584778f, 65.0965f);
            TestUtils.AreEqual(++a2, r2);

            float3 a3 = float3(148.679321f, -115.559235f, -326.8778f);
            float3 r3 = float3(149.679321f, -114.559235f, -325.8778f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float3_operator_postfix_inc()
        {
            float3 a0 = float3(322.943542f, 472.0525f, 203.48761f);
            float3 r0 = float3(322.943542f, 472.0525f, 203.48761f);
            TestUtils.AreEqual(a0++, r0);

            float3 a1 = float3(-49.8545837f, 455.3366f, 271.454651f);
            float3 r1 = float3(-49.8545837f, 455.3366f, 271.454651f);
            TestUtils.AreEqual(a1++, r1);

            float3 a2 = float3(55.7368774f, -174.173f, -427.401062f);
            float3 r2 = float3(55.7368774f, -174.173f, -427.401062f);
            TestUtils.AreEqual(a2++, r2);

            float3 a3 = float3(215.110229f, -333.050446f, 241.4649f);
            float3 r3 = float3(215.110229f, -333.050446f, 241.4649f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float3_operator_prefix_dec()
        {
            float3 a0 = float3(-416.201233f, -96.63788f, -50.14566f);
            float3 r0 = float3(-417.201233f, -97.63788f, -51.14566f);
            TestUtils.AreEqual(--a0, r0);

            float3 a1 = float3(-207.316437f, -304.400818f, 337.968933f);
            float3 r1 = float3(-208.316437f, -305.400818f, 336.968933f);
            TestUtils.AreEqual(--a1, r1);

            float3 a2 = float3(246.088989f, -227.44281f, 298.2848f);
            float3 r2 = float3(245.088989f, -228.44281f, 297.2848f);
            TestUtils.AreEqual(--a2, r2);

            float3 a3 = float3(326.5078f, -478.031372f, -326.452972f);
            float3 r3 = float3(325.5078f, -479.031372f, -327.452972f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float3_operator_postfix_dec()
        {
            float3 a0 = float3(-376.5924f, 16.9697266f, -0.2506714f);
            float3 r0 = float3(-376.5924f, 16.9697266f, -0.2506714f);
            TestUtils.AreEqual(a0--, r0);

            float3 a1 = float3(-202.323273f, 47.85663f, -281.1117f);
            float3 r1 = float3(-202.323273f, 47.85663f, -281.1117f);
            TestUtils.AreEqual(a1--, r1);

            float3 a2 = float3(-262.0626f, 450.1281f, -129.232666f);
            float3 r2 = float3(-262.0626f, 450.1281f, -129.232666f);
            TestUtils.AreEqual(a2--, r2);

            float3 a3 = float3(-332.154968f, 205.461121f, -230.227783f);
            float3 r3 = float3(-332.154968f, 205.461121f, -230.227783f);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void float3_shuffle_result_1()
        {
            float3 a = float3(0, 1, 2);
            float3 b = float3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (5));
        }

        [TestCompiler]
        public static void float3_shuffle_result_2()
        {
            float3 a = float3(0, 1, 2);
            float3 b = float3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), float2(4, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), float2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), float2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), float2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY), float2(5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), float2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftZ), float2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), float2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), float2(5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), float2(4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), float2(4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), float2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), float2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY), float2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), float2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), float2(1, 2));
        }

        [TestCompiler]
        public static void float3_shuffle_result_3()
        {
            float3 a = float3(0, 1, 2);
            float3 b = float3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.RightX), float3(1, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), float3(4, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX), float3(2, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY), float3(4, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.LeftZ), float3(5, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.LeftY), float3(2, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightX), float3(2, 4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftY, ShuffleComponent.RightZ), float3(2, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ), float3(4, 4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), float3(4, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), float3(5, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightX), float3(5, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightZ), float3(4, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightY), float3(2, 3, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), float3(4, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightZ), float3(4, 0, 5));
        }

        [TestCompiler]
        public static void float3_shuffle_result_4()
        {
            float3 a = float3(0, 1, 2);
            float3 b = float3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY), float4(1, 2, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightY), float4(4, 2, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.LeftY), float4(4, 4, 5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float4(3, 3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), float4(4, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightZ), float4(3, 4, 3, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightZ), float4(1, 5, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), float4(4, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightZ, ShuffleComponent.LeftZ, ShuffleComponent.LeftX), float4(3, 5, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), float4(4, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), float4(0, 2, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.RightZ), float4(1, 4, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), float4(2, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), float4(3, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(5, 3, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(2, 5, 0, 4));
        }


    }
}
