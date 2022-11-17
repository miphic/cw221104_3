//#define notiniteddataseta
using System;
using System.Collections.Generic;
using System.Linq;

namespace CW221104_3_fibonachi
{

    static class extends1
    {
        static public void Add(this Array obj, int k)
        {            
            psefibo.a[psefibo.count] = (ushort)k;
            psefibo.count++;
        }
    }

    static class extends2
    {
        static public void Add(this SortedDictionary<int, Pair<ushort, ushort>> obj, int TK, ushort TV1, ushort TV2)
        {
            obj.Add(TK+1, new Pair<ushort, ushort>(TV1, TV2));
        }
    }   


#if notiniteddataseta
    public
#else
    internal 
#endif 
        class Pair<T1, T2>
    {
        public T1 a;
        public T2 b;
        internal Pair(T1 x, T2 y)
        {
            a = x;
            b = y;
        }
    }

    public class psefibo
    {
        public static ushort[] a;
        public static int count;
        public static int Related;
        const int baseN=1024*1024;
#if notiniteddataseta
        public
#else
        private
#endif
            static SortedDictionary<int, Pair<ushort, ushort>> dataseta;

        internal static void printpredata()
        {
            var arr = psefibo.dataseta.Select(p => $@"{p.Key.ToString()}: {p.Value.a.ToString()}, {p.Value.b.ToString()}").ToArray();
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }

        static psefibo()
        {
            psefibo.a = new ushort[baseN];
            a[0] = 1;
            a[1] = 1;
            a[2] = 2;
            psefibo.count = 3;
            psefibo.Related = 3;
            dataseta = new SortedDictionary<int, Pair<ushort, ushort>>();
            //dataseta.Add(2 , new Pair<ushort, ushort>(a[0], a[1]));
            var t0 = DateTime.Now;
            initdataseta();
            //ushort o = 3, oiterc = 10;
            //for (var i = psefibo.count; i < psefibo.a.Length; ++i)
            //{
            //    psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
            //    if (o > oiterc)
            //    {
            //        psefibo.a[i] %= 10;
            //        psefibo.a[i - 1] %= 10;
            //        o = 0;
            //    }
            //    ++o;
            //}
            //psefibo.count = psefibo.a.Length;
            //psefibo.Related = psefibo.a.Length;
        }
        static void initdataseta()
        {
            dataseta.Add(1, 1, 1);
            dataseta.Add(6291457, 7, 9);
            dataseta.Add(79691777, 7, 4);
            dataseta.Add(899678209, 9, 5);
            dataseta.Add(999292929, 4, 5);



            //dataseta.Add(600005, 1, 1);
            dataseta.Add(1048578, 7, 4);
            dataseta.Add(2097154, 8, 7);
            dataseta.Add(3145730, 9, 5);
            dataseta.Add(4194306, 5, 8);
            //dataseta.Add(5242882, 6, 1);
            //dataseta.Add(7000006, 7, 9);
            dataseta.Add(7340034, 3, 2);
            dataseta.Add(8388610, 4, 5);
            dataseta.Add(9437186, 5, 3);
            dataseta.Add(10485762, 1, 6);
            dataseta.Add(11534338, 2, 9);
            dataseta.Add(12582914, 3, 7);
            dataseta.Add(13631490, 9, 0);
            dataseta.Add(14680066, 0, 3);
            dataseta.Add(15728642, 1, 1);
            dataseta.Add(16777218, 7, 4);
            dataseta.Add(17825794, 8, 7);
            dataseta.Add(18874370, 9, 5);
            dataseta.Add(19922946, 5, 8);
            dataseta.Add(20971522, 6, 1);
            dataseta.Add(22020098, 7, 9);
            dataseta.Add(23068674, 3, 2);
            dataseta.Add(24117250, 4, 5);
            dataseta.Add(25165826, 5, 3);
            dataseta.Add(26214402, 1, 6);
            dataseta.Add(27262978, 2, 9);
            dataseta.Add(28311554, 3, 7);
            dataseta.Add(29360130, 9, 0);
            dataseta.Add(30408706, 0, 3);
            dataseta.Add(31457282, 1, 1);
            dataseta.Add(32505858, 7, 4);
            dataseta.Add(33554434, 8, 7);
            dataseta.Add(34603010, 9, 5);
            dataseta.Add(35651586, 5, 8);
            dataseta.Add(36700162, 6, 1);
            dataseta.Add(37748738, 7, 9);
            dataseta.Add(38797314, 3, 2);
            dataseta.Add(39845890, 4, 5);
            dataseta.Add(40894466, 5, 3);
            dataseta.Add(41943042, 1, 6);
            dataseta.Add(42991618, 2, 9);
            dataseta.Add(44040194, 3, 7);
            dataseta.Add(45088770, 9, 0);
            dataseta.Add(46137346, 0, 3);
            dataseta.Add(47185922, 1, 1);
            dataseta.Add(48234498, 7, 4);
            dataseta.Add(49283074, 8, 7);
            dataseta.Add(50331650, 9, 5);
            dataseta.Add(51380226, 5, 8);
            dataseta.Add(52428802, 6, 1);
            dataseta.Add(53477378, 7, 9);
            dataseta.Add(54525954, 3, 2);
            dataseta.Add(55574530, 4, 5);
            dataseta.Add(56623106, 5, 3);
            dataseta.Add(57671682, 1, 6);
            dataseta.Add(58720258, 2, 9);
            dataseta.Add(59768834, 3, 7);
            dataseta.Add(60817410, 9, 0);
            dataseta.Add(61865986, 0, 3);
            dataseta.Add(62914562, 1, 1);
            dataseta.Add(63963138, 7, 4);
            dataseta.Add(65011714, 8, 7);
            dataseta.Add(66060290, 9, 5);
            dataseta.Add(67108866, 5, 8);
            dataseta.Add(68157442, 6, 1);
            dataseta.Add(69206018, 7, 9);
            dataseta.Add(70254594, 3, 2);
            dataseta.Add(71303170, 4, 5);
            dataseta.Add(72351746, 5, 3);
            dataseta.Add(73400322, 1, 6);
            dataseta.Add(74448898, 2, 9);
            dataseta.Add(75497474, 3, 7);
            dataseta.Add(76546050, 9, 0);
            dataseta.Add(77594626, 0, 3);
            //dataseta.Add(78643202, 1, 1);
            //dataseta.Add(80000007, 7, 4);
            dataseta.Add(80740354, 8, 7);
            dataseta.Add(81788930, 9, 5);
            dataseta.Add(82837506, 5, 8);
            dataseta.Add(83886082, 6, 1);
            dataseta.Add(84934658, 7, 9);
            dataseta.Add(85983234, 3, 2);
            dataseta.Add(87031810, 4, 5);
            dataseta.Add(88080386, 5, 3);
            dataseta.Add(89128962, 1, 6);
            dataseta.Add(90177538, 2, 9);
            dataseta.Add(91226114, 3, 7);
            dataseta.Add(92274690, 9, 0);
            dataseta.Add(93323266, 0, 3);
            dataseta.Add(94371842, 1, 1);
            dataseta.Add(95420418, 7, 4);
            dataseta.Add(96468994, 8, 7);
            dataseta.Add(97517570, 9, 5);
            dataseta.Add(98566146, 5, 8);
            dataseta.Add(99614722, 6, 1);
            dataseta.Add(100663298, 7, 9);
            dataseta.Add(101711874, 3, 2);
            dataseta.Add(102760450, 4, 5);
            dataseta.Add(103809026, 5, 3);
            dataseta.Add(104857602, 1, 6);
            dataseta.Add(105906178, 2, 9);
            dataseta.Add(106954754, 3, 7);
            dataseta.Add(108003330, 9, 0);
            dataseta.Add(109051906, 0, 3);
            dataseta.Add(110100482, 1, 1);
            dataseta.Add(111149058, 7, 4);
            dataseta.Add(112197634, 8, 7);
            dataseta.Add(113246210, 9, 5);
            dataseta.Add(114294786, 5, 8);
            dataseta.Add(115343362, 6, 1);
            dataseta.Add(116391938, 7, 9);
            dataseta.Add(117440514, 3, 2);
            dataseta.Add(118489090, 4, 5);
            dataseta.Add(119537666, 5, 3);
            dataseta.Add(120586242, 1, 6);
            dataseta.Add(121634818, 2, 9);
            dataseta.Add(122683394, 3, 7);
            dataseta.Add(123731970, 9, 0);
            dataseta.Add(124780546, 0, 3);
            dataseta.Add(125829122, 1, 1);
            dataseta.Add(126877698, 7, 4);
            dataseta.Add(127926274, 8, 7);
            dataseta.Add(128974850, 9, 5);
            dataseta.Add(130023426, 5, 8);
            dataseta.Add(131072002, 6, 1);
            dataseta.Add(132120578, 7, 9);
            dataseta.Add(133169154, 3, 2);
            dataseta.Add(134217730, 4, 5);
            dataseta.Add(135266306, 5, 3);
            dataseta.Add(136314882, 1, 6);
            dataseta.Add(137363458, 2, 9);
            dataseta.Add(138412034, 3, 7);
            dataseta.Add(139460610, 9, 0);
            dataseta.Add(140509186, 0, 3);
            dataseta.Add(141557762, 1, 1);
            dataseta.Add(142606338, 7, 4);
            dataseta.Add(143654914, 8, 7);
            dataseta.Add(144703490, 9, 5);
            dataseta.Add(145752066, 5, 8);
            dataseta.Add(146800642, 6, 1);
            dataseta.Add(147849218, 7, 9);
            dataseta.Add(148897794, 3, 2);
            dataseta.Add(149946370, 4, 5);
            dataseta.Add(150994946, 5, 3);
            dataseta.Add(152043522, 1, 6);
            dataseta.Add(153092098, 2, 9);
            dataseta.Add(154140674, 3, 7);
            dataseta.Add(155189250, 9, 0);
            dataseta.Add(156237826, 0, 3);
            dataseta.Add(157286402, 1, 1);
            dataseta.Add(158334978, 7, 4);
            dataseta.Add(159383554, 8, 7);
            dataseta.Add(160432130, 9, 5);
            dataseta.Add(161480706, 5, 8);
            dataseta.Add(162529282, 6, 1);
            dataseta.Add(163577858, 7, 9);
            dataseta.Add(164626434, 3, 2);
            dataseta.Add(165675010, 4, 5);
            dataseta.Add(166723586, 5, 3);
            dataseta.Add(167772162, 1, 6);
            dataseta.Add(168820738, 2, 9);
            dataseta.Add(169869314, 3, 7);
            dataseta.Add(170917890, 9, 0);
            dataseta.Add(171966466, 0, 3);
            dataseta.Add(173015042, 1, 1);
            dataseta.Add(174063618, 7, 4);
            dataseta.Add(175112194, 8, 7);
            dataseta.Add(176160770, 9, 5);
            dataseta.Add(177209346, 5, 8);
            dataseta.Add(178257922, 6, 1);
            dataseta.Add(179306498, 7, 9);
            dataseta.Add(180355074, 3, 2);
            dataseta.Add(181403650, 4, 5);
            dataseta.Add(182452226, 5, 3);
            dataseta.Add(183500802, 1, 6);
            dataseta.Add(184549378, 2, 9);
            dataseta.Add(185597954, 3, 7);
            dataseta.Add(186646530, 9, 0);
            dataseta.Add(187695106, 0, 3);
            dataseta.Add(188743682, 1, 1);
            dataseta.Add(189792258, 7, 4);
            dataseta.Add(190840834, 8, 7);
            dataseta.Add(191889410, 9, 5);
            dataseta.Add(192937986, 5, 8);
            dataseta.Add(193986562, 6, 1);
            dataseta.Add(195035138, 7, 9);
            dataseta.Add(196083714, 3, 2);
            dataseta.Add(197132290, 4, 5);
            dataseta.Add(198180866, 5, 3);
            dataseta.Add(199229442, 1, 6);
            dataseta.Add(200278018, 2, 9);
            dataseta.Add(201326594, 3, 7);
            dataseta.Add(202375170, 9, 0);
            dataseta.Add(203423746, 0, 3);
            dataseta.Add(204472322, 1, 1);
            dataseta.Add(205520898, 7, 4);
            dataseta.Add(206569474, 8, 7);
            dataseta.Add(207618050, 9, 5);
            dataseta.Add(208666626, 5, 8);
            dataseta.Add(209715202, 6, 1);
            dataseta.Add(210763778, 7, 9);
            dataseta.Add(211812354, 3, 2);
            dataseta.Add(212860930, 4, 5);
            dataseta.Add(213909506, 5, 3);
            dataseta.Add(214958082, 1, 6);
            dataseta.Add(216006658, 2, 9);
            dataseta.Add(217055234, 3, 7);
            dataseta.Add(218103810, 9, 0);
            dataseta.Add(219152386, 0, 3);
            dataseta.Add(220200962, 1, 1);
            dataseta.Add(221249538, 7, 4);
            dataseta.Add(222298114, 8, 7);
            dataseta.Add(223346690, 9, 5);
            dataseta.Add(224395266, 5, 8);
            dataseta.Add(225443842, 6, 1);
            dataseta.Add(226492418, 7, 9);
            dataseta.Add(227540994, 3, 2);
            dataseta.Add(228589570, 4, 5);
            dataseta.Add(229638146, 5, 3);
            dataseta.Add(230686722, 1, 6);
            dataseta.Add(231735298, 2, 9);
            dataseta.Add(232783874, 3, 7);
            dataseta.Add(233832450, 9, 0);
            dataseta.Add(234881026, 0, 3);
            dataseta.Add(235929602, 1, 1);
            dataseta.Add(236978178, 7, 4);
            dataseta.Add(238026754, 8, 7);
            dataseta.Add(239075330, 9, 5);
            dataseta.Add(240123906, 5, 8);
            dataseta.Add(241172482, 6, 1);
            dataseta.Add(242221058, 7, 9);
            dataseta.Add(243269634, 3, 2);
            dataseta.Add(244318210, 4, 5);
            dataseta.Add(245366786, 5, 3);
            dataseta.Add(246415362, 1, 6);
            dataseta.Add(247463938, 2, 9);
            dataseta.Add(248512514, 3, 7);
            dataseta.Add(249561090, 9, 0);
            dataseta.Add(250609666, 0, 3);
            dataseta.Add(251658242, 1, 1);
            dataseta.Add(252706818, 7, 4);
            dataseta.Add(253755394, 8, 7);
            dataseta.Add(254803970, 9, 5);
            dataseta.Add(255852546, 5, 8);
            dataseta.Add(256901122, 6, 1);
            dataseta.Add(257949698, 7, 9);
            dataseta.Add(258998274, 3, 2);
            dataseta.Add(260046850, 4, 5);
            dataseta.Add(261095426, 5, 3);
            dataseta.Add(262144002, 1, 6);
            dataseta.Add(263192578, 2, 9);
            dataseta.Add(264241154, 3, 7);
            dataseta.Add(265289730, 9, 0);
            dataseta.Add(266338306, 0, 3);
            dataseta.Add(267386882, 1, 1);
            dataseta.Add(268435458, 7, 4);
            dataseta.Add(269484034, 8, 7);
            dataseta.Add(270532610, 9, 5);
            dataseta.Add(271581186, 5, 8);
            dataseta.Add(272629762, 6, 1);
            dataseta.Add(273678338, 7, 9);
            dataseta.Add(274726914, 3, 2);
            dataseta.Add(275775490, 4, 5);
            dataseta.Add(276824066, 5, 3);
            dataseta.Add(277872642, 1, 6);
            dataseta.Add(278921218, 2, 9);
            dataseta.Add(279969794, 3, 7);
            dataseta.Add(281018370, 9, 0);
            dataseta.Add(282066946, 0, 3);
            dataseta.Add(283115522, 1, 1);
            dataseta.Add(284164098, 7, 4);
            dataseta.Add(285212674, 8, 7);
            dataseta.Add(286261250, 9, 5);
            dataseta.Add(287309826, 5, 8);
            dataseta.Add(288358402, 6, 1);
            dataseta.Add(289406978, 7, 9);
            dataseta.Add(290455554, 3, 2);
            dataseta.Add(291504130, 4, 5);
            dataseta.Add(292552706, 5, 3);
            dataseta.Add(293601282, 1, 6);
            dataseta.Add(294649858, 2, 9);
            dataseta.Add(295698434, 3, 7);
            dataseta.Add(296747010, 9, 0);
            dataseta.Add(297795586, 0, 3);
            dataseta.Add(298844162, 1, 1);
            dataseta.Add(299892738, 7, 4);
            dataseta.Add(300941314, 8, 7);
            dataseta.Add(301989890, 9, 5);
            dataseta.Add(303038466, 5, 8);
            dataseta.Add(304087042, 6, 1);
            dataseta.Add(305135618, 7, 9);
            dataseta.Add(306184194, 3, 2);
            dataseta.Add(307232770, 4, 5);
            dataseta.Add(308281346, 5, 3);
            dataseta.Add(309329922, 1, 6);
            dataseta.Add(310378498, 2, 9);
            dataseta.Add(311427074, 3, 7);
            dataseta.Add(312475650, 9, 0);
            dataseta.Add(313524226, 0, 3);
            dataseta.Add(314572802, 1, 1);
            dataseta.Add(315621378, 7, 4);
            dataseta.Add(316669954, 8, 7);
            dataseta.Add(317718530, 9, 5);
            dataseta.Add(318767106, 5, 8);
            dataseta.Add(319815682, 6, 1);
            dataseta.Add(320864258, 7, 9);
            dataseta.Add(321912834, 3, 2);
            dataseta.Add(322961410, 4, 5);
            dataseta.Add(324009986, 5, 3);
            dataseta.Add(325058562, 1, 6);
            dataseta.Add(326107138, 2, 9);
            dataseta.Add(327155714, 3, 7);
            dataseta.Add(328204290, 9, 0);
            dataseta.Add(329252866, 0, 3);
            dataseta.Add(330301442, 1, 1);
            dataseta.Add(331350018, 7, 4);
            dataseta.Add(332398594, 8, 7);
            dataseta.Add(333447170, 9, 5);
            dataseta.Add(334495746, 5, 8);
            dataseta.Add(335544322, 6, 1);
            dataseta.Add(336592898, 7, 9);
            dataseta.Add(337641474, 3, 2);
            dataseta.Add(338690050, 4, 5);
            dataseta.Add(339738626, 5, 3);
            dataseta.Add(340787202, 1, 6);
            dataseta.Add(341835778, 2, 9);
            dataseta.Add(342884354, 3, 7);
            dataseta.Add(343932930, 9, 0);
            dataseta.Add(344981506, 0, 3);
            dataseta.Add(346030082, 1, 1);
            dataseta.Add(347078658, 7, 4);
            dataseta.Add(348127234, 8, 7);
            dataseta.Add(349175810, 9, 5);
            dataseta.Add(350224386, 5, 8);
            dataseta.Add(351272962, 6, 1);
            dataseta.Add(352321538, 7, 9);
            dataseta.Add(353370114, 3, 2);
            dataseta.Add(354418690, 4, 5);
            dataseta.Add(355467266, 5, 3);
            dataseta.Add(356515842, 1, 6);
            dataseta.Add(357564418, 2, 9);
            dataseta.Add(358612994, 3, 7);
            dataseta.Add(359661570, 9, 0);
            dataseta.Add(360710146, 0, 3);
            dataseta.Add(361758722, 1, 1);
            dataseta.Add(362807298, 7, 4);
            dataseta.Add(363855874, 8, 7);
            dataseta.Add(364904450, 9, 5);
            dataseta.Add(365953026, 5, 8);
            dataseta.Add(367001602, 6, 1);
            dataseta.Add(368050178, 7, 9);
            dataseta.Add(369098754, 3, 2);
            dataseta.Add(370147330, 4, 5);
            dataseta.Add(371195906, 5, 3);
            dataseta.Add(372244482, 1, 6);
            dataseta.Add(373293058, 2, 9);
            dataseta.Add(374341634, 3, 7);
            dataseta.Add(375390210, 9, 0);
            dataseta.Add(376438786, 0, 3);
            dataseta.Add(377487362, 1, 1);
            dataseta.Add(378535938, 7, 4);
            dataseta.Add(379584514, 8, 7);
            dataseta.Add(380633090, 9, 5);
            dataseta.Add(381681666, 5, 8);
            dataseta.Add(382730242, 6, 1);
            dataseta.Add(383778818, 7, 9);
            dataseta.Add(384827394, 3, 2);
            dataseta.Add(385875970, 4, 5);
            dataseta.Add(386924546, 5, 3);
            dataseta.Add(387973122, 1, 6);
            dataseta.Add(389021698, 2, 9);
            dataseta.Add(390070274, 3, 7);
            dataseta.Add(391118850, 9, 0);
            dataseta.Add(392167426, 0, 3);
            dataseta.Add(393216002, 1, 1);
            dataseta.Add(394264578, 7, 4);
            dataseta.Add(395313154, 8, 7);
            dataseta.Add(396361730, 9, 5);
            dataseta.Add(397410306, 5, 8);
            dataseta.Add(398458882, 6, 1);
            dataseta.Add(399507458, 7, 9);
            dataseta.Add(400556034, 3, 2);
            dataseta.Add(401604610, 4, 5);
            dataseta.Add(402653186, 5, 3);
            dataseta.Add(403701762, 1, 6);
            dataseta.Add(404750338, 2, 9);
            dataseta.Add(405798914, 3, 7);
            dataseta.Add(406847490, 9, 0);
            dataseta.Add(407896066, 0, 3);
            dataseta.Add(408944642, 1, 1);
            dataseta.Add(409993218, 7, 4);
            dataseta.Add(411041794, 8, 7);
            dataseta.Add(412090370, 9, 5);
            dataseta.Add(413138946, 5, 8);
            dataseta.Add(414187522, 6, 1);
            dataseta.Add(415236098, 7, 9);
            dataseta.Add(416284674, 3, 2);
            dataseta.Add(417333250, 4, 5);
            dataseta.Add(418381826, 5, 3);
            dataseta.Add(419430402, 1, 6);
            dataseta.Add(420478978, 2, 9);
            dataseta.Add(421527554, 3, 7);
            dataseta.Add(422576130, 9, 0);
            dataseta.Add(423624706, 0, 3);
            dataseta.Add(424673282, 1, 1);
            dataseta.Add(425721858, 7, 4);
            dataseta.Add(426770434, 8, 7);
            dataseta.Add(427819010, 9, 5);
            dataseta.Add(428867586, 5, 8);
            dataseta.Add(429916162, 6, 1);
            dataseta.Add(430964738, 7, 9);
            dataseta.Add(432013314, 3, 2);
            dataseta.Add(433061890, 4, 5);
            dataseta.Add(434110466, 5, 3);
            dataseta.Add(435159042, 1, 6);
            dataseta.Add(436207618, 2, 9);
            dataseta.Add(437256194, 3, 7);
            dataseta.Add(438304770, 9, 0);
            dataseta.Add(439353346, 0, 3);
            dataseta.Add(440401922, 1, 1);
            dataseta.Add(441450498, 7, 4);
            dataseta.Add(442499074, 8, 7);
            dataseta.Add(443547650, 9, 5);
            dataseta.Add(444596226, 5, 8);
            dataseta.Add(445644802, 6, 1);
            dataseta.Add(446693378, 7, 9);
            dataseta.Add(447741954, 3, 2);
            dataseta.Add(448790530, 4, 5);
            dataseta.Add(449839106, 5, 3);
            dataseta.Add(450887682, 1, 6);
            dataseta.Add(451936258, 2, 9);
            dataseta.Add(452984834, 3, 7);
            dataseta.Add(454033410, 9, 0);
            dataseta.Add(455081986, 0, 3);
            dataseta.Add(456130562, 1, 1);
            dataseta.Add(457179138, 7, 4);
            dataseta.Add(458227714, 8, 7);
            dataseta.Add(459276290, 9, 5);
            dataseta.Add(460324866, 5, 8);
            dataseta.Add(461373442, 6, 1);
            dataseta.Add(462422018, 7, 9);
            dataseta.Add(463470594, 3, 2);
            dataseta.Add(464519170, 4, 5);
            dataseta.Add(465567746, 5, 3);
            dataseta.Add(466616322, 1, 6);
            dataseta.Add(467664898, 2, 9);
            dataseta.Add(468713474, 3, 7);
            dataseta.Add(469762050, 9, 0);
            dataseta.Add(470810626, 0, 3);
            dataseta.Add(471859202, 1, 1);
            dataseta.Add(472907778, 7, 4);
            dataseta.Add(473956354, 8, 7);
            dataseta.Add(475004930, 9, 5);
            dataseta.Add(476053506, 5, 8);
            dataseta.Add(477102082, 6, 1);
            dataseta.Add(478150658, 7, 9);
            dataseta.Add(479199234, 3, 2);
            dataseta.Add(480247810, 4, 5);
            dataseta.Add(481296386, 5, 3);
            dataseta.Add(482344962, 1, 6);
            dataseta.Add(483393538, 2, 9);
            dataseta.Add(484442114, 3, 7);
            dataseta.Add(485490690, 9, 0);
            dataseta.Add(486539266, 0, 3);
            dataseta.Add(487587842, 1, 1);
            dataseta.Add(488636418, 7, 4);
            dataseta.Add(489684994, 8, 7);
            dataseta.Add(490733570, 9, 5);
            dataseta.Add(491782146, 5, 8);
            dataseta.Add(492830722, 6, 1);
            dataseta.Add(493879298, 7, 9);
            dataseta.Add(494927874, 3, 2);
            dataseta.Add(495976450, 4, 5);
            dataseta.Add(497025026, 5, 3);
            dataseta.Add(498073602, 1, 6);
            dataseta.Add(499122178, 2, 9);
            dataseta.Add(500170754, 3, 7);
            dataseta.Add(501219330, 9, 0);
            dataseta.Add(502267906, 0, 3);
            dataseta.Add(503316482, 1, 1);
            dataseta.Add(504365058, 7, 4);
            dataseta.Add(505413634, 8, 7);
            dataseta.Add(506462210, 9, 5);
            dataseta.Add(507510786, 5, 8);
            dataseta.Add(508559362, 6, 1);
            dataseta.Add(509607938, 7, 9);
            dataseta.Add(510656514, 3, 2);
            dataseta.Add(511705090, 4, 5);
            dataseta.Add(512753666, 5, 3);
            dataseta.Add(513802242, 1, 6);
            dataseta.Add(514850818, 2, 9);
            dataseta.Add(515899394, 3, 7);
            dataseta.Add(516947970, 9, 0);
            dataseta.Add(517996546, 0, 3);
            dataseta.Add(519045122, 1, 1);
            dataseta.Add(520093698, 7, 4);
            dataseta.Add(521142274, 8, 7);
            dataseta.Add(522190850, 9, 5);
            dataseta.Add(523239426, 5, 8);
            dataseta.Add(524288002, 6, 1);
            dataseta.Add(525336578, 7, 9);
            dataseta.Add(526385154, 3, 2);
            dataseta.Add(527433730, 4, 5);
            dataseta.Add(528482306, 5, 3);
            dataseta.Add(529530882, 1, 6);
            dataseta.Add(530579458, 2, 9);
            dataseta.Add(531628034, 3, 7);
            dataseta.Add(532676610, 9, 0);
            dataseta.Add(533725186, 0, 3);
            dataseta.Add(534773762, 1, 1);
            dataseta.Add(535822338, 7, 4);
            dataseta.Add(536870914, 8, 7);
            dataseta.Add(537919490, 9, 5);
            dataseta.Add(538968066, 5, 8);
            dataseta.Add(540016642, 6, 1);
            dataseta.Add(541065218, 7, 9);
            dataseta.Add(542113794, 3, 2);
            dataseta.Add(543162370, 4, 5);
            dataseta.Add(544210946, 5, 3);
            dataseta.Add(545259522, 1, 6);
            dataseta.Add(546308098, 2, 9);
            dataseta.Add(547356674, 3, 7);
            dataseta.Add(548405250, 9, 0);
            dataseta.Add(549453826, 0, 3);
            dataseta.Add(550502402, 1, 1);
            dataseta.Add(551550978, 7, 4);
            dataseta.Add(552599554, 8, 7);
            dataseta.Add(553648130, 9, 5);
            dataseta.Add(554696706, 5, 8);
            dataseta.Add(555745282, 6, 1);
            dataseta.Add(556793858, 7, 9);
            dataseta.Add(557842434, 3, 2);
            dataseta.Add(558891010, 4, 5);
            dataseta.Add(559939586, 5, 3);
            dataseta.Add(560988162, 1, 6);
            dataseta.Add(562036738, 2, 9);
            dataseta.Add(563085314, 3, 7);
            dataseta.Add(564133890, 9, 0);
            dataseta.Add(565182466, 0, 3);
            dataseta.Add(566231042, 1, 1);
            dataseta.Add(567279618, 7, 4);
            dataseta.Add(568328194, 8, 7);
            dataseta.Add(569376770, 9, 5);
            dataseta.Add(570425346, 5, 8);
            dataseta.Add(571473922, 6, 1);
            dataseta.Add(572522498, 7, 9);
            dataseta.Add(573571074, 3, 2);
            dataseta.Add(574619650, 4, 5);
            dataseta.Add(575668226, 5, 3);
            dataseta.Add(576716802, 1, 6);
            dataseta.Add(577765378, 2, 9);
            dataseta.Add(578813954, 3, 7);
            dataseta.Add(579862530, 9, 0);
            dataseta.Add(580911106, 0, 3);
            dataseta.Add(581959682, 1, 1);
            dataseta.Add(583008258, 7, 4);
            dataseta.Add(584056834, 8, 7);
            dataseta.Add(585105410, 9, 5);
            dataseta.Add(586153986, 5, 8);
            dataseta.Add(587202562, 6, 1);
            dataseta.Add(588251138, 7, 9);
            dataseta.Add(589299714, 3, 2);
            dataseta.Add(590348290, 4, 5);
            dataseta.Add(591396866, 5, 3);
            dataseta.Add(592445442, 1, 6);
            dataseta.Add(593494018, 2, 9);
            dataseta.Add(594542594, 3, 7);
            dataseta.Add(595591170, 9, 0);
            dataseta.Add(596639746, 0, 3);
            dataseta.Add(597688322, 1, 1);
            dataseta.Add(598736898, 7, 4);
            dataseta.Add(599785474, 8, 7);
            dataseta.Add(600834050, 9, 5);
            dataseta.Add(601882626, 5, 8);
            dataseta.Add(602931202, 6, 1);
            dataseta.Add(603979778, 7, 9);
            dataseta.Add(605028354, 3, 2);
            dataseta.Add(606076930, 4, 5);
            dataseta.Add(607125506, 5, 3);
            dataseta.Add(608174082, 1, 6);
            dataseta.Add(609222658, 2, 9);
            dataseta.Add(610271234, 3, 7);
            dataseta.Add(611319810, 9, 0);
            dataseta.Add(612368386, 0, 3);
            dataseta.Add(613416962, 1, 1);
            dataseta.Add(614465538, 7, 4);
            dataseta.Add(615514114, 8, 7);
            dataseta.Add(616562690, 9, 5);
            dataseta.Add(617611266, 5, 8);
            dataseta.Add(618659842, 6, 1);
            dataseta.Add(619708418, 7, 9);
            dataseta.Add(620756994, 3, 2);
            dataseta.Add(621805570, 4, 5);
            dataseta.Add(622854146, 5, 3);
            dataseta.Add(623902722, 1, 6);
            dataseta.Add(624951298, 2, 9);
            dataseta.Add(625999874, 3, 7);
            dataseta.Add(627048450, 9, 0);
            dataseta.Add(628097026, 0, 3);
            dataseta.Add(629145602, 1, 1);
            dataseta.Add(630194178, 7, 4);
            dataseta.Add(631242754, 8, 7);
            dataseta.Add(632291330, 9, 5);
            dataseta.Add(633339906, 5, 8);
            dataseta.Add(634388482, 6, 1);
            dataseta.Add(635437058, 7, 9);
            dataseta.Add(636485634, 3, 2);
            dataseta.Add(637534210, 4, 5);
            dataseta.Add(638582786, 5, 3);
            dataseta.Add(639631362, 1, 6);
            dataseta.Add(640679938, 2, 9);
            dataseta.Add(641728514, 3, 7);
            dataseta.Add(642777090, 9, 0);
            dataseta.Add(643825666, 0, 3);
            dataseta.Add(644874242, 1, 1);
            dataseta.Add(645922818, 7, 4);
            dataseta.Add(646971394, 8, 7);
            dataseta.Add(648019970, 9, 5);
            dataseta.Add(649068546, 5, 8);
            dataseta.Add(650117122, 6, 1);
            dataseta.Add(651165698, 7, 9);
            dataseta.Add(652214274, 3, 2);
            dataseta.Add(653262850, 4, 5);
            dataseta.Add(654311426, 5, 3);
            dataseta.Add(655360002, 1, 6);
            dataseta.Add(656408578, 2, 9);
            dataseta.Add(657457154, 3, 7);
            dataseta.Add(658505730, 9, 0);
            dataseta.Add(659554306, 0, 3);
            dataseta.Add(660602882, 1, 1);
            dataseta.Add(661651458, 7, 4);
            dataseta.Add(662700034, 8, 7);
            dataseta.Add(663748610, 9, 5);
            dataseta.Add(664797186, 5, 8);
            dataseta.Add(665845762, 6, 1);
            dataseta.Add(666894338, 7, 9);
            dataseta.Add(667942914, 3, 2);
            dataseta.Add(668991490, 4, 5);
            dataseta.Add(670040066, 5, 3);
            dataseta.Add(671088642, 1, 6);
            dataseta.Add(672137218, 2, 9);
            dataseta.Add(673185794, 3, 7);
            dataseta.Add(674234370, 9, 0);
            dataseta.Add(675282946, 0, 3);
            dataseta.Add(676331522, 1, 1);
            dataseta.Add(677380098, 7, 4);
            dataseta.Add(678428674, 8, 7);
            dataseta.Add(679477250, 9, 5);
            dataseta.Add(680525826, 5, 8);
            dataseta.Add(681574402, 6, 1);
            dataseta.Add(682622978, 7, 9);
            dataseta.Add(683671554, 3, 2);
            dataseta.Add(684720130, 4, 5);
            dataseta.Add(685768706, 5, 3);
            dataseta.Add(686817282, 1, 6);
            dataseta.Add(687865858, 2, 9);
            dataseta.Add(688914434, 3, 7);
            dataseta.Add(689963010, 9, 0);
            dataseta.Add(691011586, 0, 3);
            dataseta.Add(692060162, 1, 1);
            dataseta.Add(693108738, 7, 4);
            dataseta.Add(694157314, 8, 7);
            dataseta.Add(695205890, 9, 5);
            dataseta.Add(696254466, 5, 8);
            dataseta.Add(697303042, 6, 1);
            dataseta.Add(698351618, 7, 9);
            dataseta.Add(699400194, 3, 2);
            dataseta.Add(700448770, 4, 5);
            dataseta.Add(701497346, 5, 3);
            dataseta.Add(702545922, 1, 6);
            dataseta.Add(703594498, 2, 9);
            dataseta.Add(704643074, 3, 7);
            dataseta.Add(705691650, 9, 0);
            dataseta.Add(706740226, 0, 3);
            dataseta.Add(707788802, 1, 1);
            dataseta.Add(708837378, 7, 4);
            dataseta.Add(709885954, 8, 7);
            dataseta.Add(710934530, 9, 5);
            dataseta.Add(711983106, 5, 8);
            dataseta.Add(713031682, 6, 1);
            dataseta.Add(714080258, 7, 9);
            dataseta.Add(715128834, 3, 2);
            dataseta.Add(716177410, 4, 5);
            dataseta.Add(717225986, 5, 3);
            dataseta.Add(718274562, 1, 6);
            dataseta.Add(719323138, 2, 9);
            dataseta.Add(720371714, 3, 7);
            dataseta.Add(721420290, 9, 0);
            dataseta.Add(722468866, 0, 3);
            dataseta.Add(723517442, 1, 1);
            dataseta.Add(724566018, 7, 4);
            dataseta.Add(725614594, 8, 7);
            dataseta.Add(726663170, 9, 5);
            dataseta.Add(727711746, 5, 8);
            dataseta.Add(728760322, 6, 1);
            dataseta.Add(729808898, 7, 9);
            dataseta.Add(730857474, 3, 2);
            dataseta.Add(731906050, 4, 5);
            dataseta.Add(732954626, 5, 3);
            dataseta.Add(734003202, 1, 6);
            dataseta.Add(735051778, 2, 9);
            dataseta.Add(736100354, 3, 7);
            dataseta.Add(737148930, 9, 0);
            dataseta.Add(738197506, 0, 3);
            dataseta.Add(739246082, 1, 1);
            dataseta.Add(740294658, 7, 4);
            dataseta.Add(741343234, 8, 7);
            dataseta.Add(742391810, 9, 5);
            dataseta.Add(743440386, 5, 8);
            dataseta.Add(744488962, 6, 1);
            dataseta.Add(745537538, 7, 9);
            dataseta.Add(746586114, 3, 2);
            dataseta.Add(747634690, 4, 5);
            dataseta.Add(748683266, 5, 3);
            dataseta.Add(749731842, 1, 6);
            dataseta.Add(750780418, 2, 9);
            dataseta.Add(751828994, 3, 7);
            dataseta.Add(752877570, 9, 0);
            dataseta.Add(753926146, 0, 3);
            dataseta.Add(754974722, 1, 1);
            dataseta.Add(756023298, 7, 4);
            dataseta.Add(757071874, 8, 7);
            dataseta.Add(758120450, 9, 5);
            dataseta.Add(759169026, 5, 8);
            dataseta.Add(760217602, 6, 1);
            dataseta.Add(761266178, 7, 9);
            dataseta.Add(762314754, 3, 2);
            dataseta.Add(763363330, 4, 5);
            dataseta.Add(764411906, 5, 3);
            dataseta.Add(765460482, 1, 6);
            dataseta.Add(766509058, 2, 9);
            dataseta.Add(767557634, 3, 7);
            dataseta.Add(768606210, 9, 0);
            dataseta.Add(769654786, 0, 3);
            dataseta.Add(770703362, 1, 1);
            dataseta.Add(771751938, 7, 4);
            dataseta.Add(772800514, 8, 7);
            dataseta.Add(773849090, 9, 5);
            dataseta.Add(774897666, 5, 8);
            dataseta.Add(775946242, 6, 1);
            dataseta.Add(776994818, 7, 9);
            dataseta.Add(778043394, 3, 2);
            dataseta.Add(779091970, 4, 5);
            dataseta.Add(780140546, 5, 3);
            dataseta.Add(781189122, 1, 6);
            dataseta.Add(782237698, 2, 9);
            dataseta.Add(783286274, 3, 7);
            dataseta.Add(784334850, 9, 0);
            dataseta.Add(785383426, 0, 3);
            dataseta.Add(786432002, 1, 1);
            dataseta.Add(787480578, 7, 4);
            dataseta.Add(788529154, 8, 7);
            dataseta.Add(789577730, 9, 5);
            dataseta.Add(790626306, 5, 8);
            dataseta.Add(791674882, 6, 1);
            dataseta.Add(792723458, 7, 9);
            dataseta.Add(793772034, 3, 2);
            dataseta.Add(794820610, 4, 5);
            dataseta.Add(795869186, 5, 3);
            dataseta.Add(796917762, 1, 6);
            dataseta.Add(797966338, 2, 9);
            dataseta.Add(799014914, 3, 7);
            dataseta.Add(800063490, 9, 0);
            dataseta.Add(801112066, 0, 3);
            dataseta.Add(802160642, 1, 1);
            dataseta.Add(803209218, 7, 4);
            dataseta.Add(804257794, 8, 7);
            dataseta.Add(805306370, 9, 5);
            dataseta.Add(806354946, 5, 8);
            dataseta.Add(807403522, 6, 1);
            dataseta.Add(808452098, 7, 9);
            dataseta.Add(809500674, 3, 2);
            dataseta.Add(810549250, 4, 5);
            dataseta.Add(811597826, 5, 3);
            dataseta.Add(812646402, 1, 6);
            dataseta.Add(813694978, 2, 9);
            dataseta.Add(814743554, 3, 7);
            dataseta.Add(815792130, 9, 0);
            dataseta.Add(816840706, 0, 3);
            dataseta.Add(817889282, 1, 1);
            dataseta.Add(818937858, 7, 4);
            dataseta.Add(819986434, 8, 7);
            dataseta.Add(821035010, 9, 5);
            dataseta.Add(822083586, 5, 8);
            dataseta.Add(823132162, 6, 1);
            dataseta.Add(824180738, 7, 9);
            dataseta.Add(825229314, 3, 2);
            dataseta.Add(826277890, 4, 5);
            dataseta.Add(827326466, 5, 3);
            dataseta.Add(828375042, 1, 6);
            dataseta.Add(829423618, 2, 9);
            dataseta.Add(830472194, 3, 7);
            dataseta.Add(831520770, 9, 0);
            dataseta.Add(832569346, 0, 3);
            dataseta.Add(833617922, 1, 1);
            dataseta.Add(834666498, 7, 4);
            dataseta.Add(835715074, 8, 7);
            dataseta.Add(836763650, 9, 5);
            dataseta.Add(837812226, 5, 8);
            dataseta.Add(838860802, 6, 1);
            dataseta.Add(839909378, 7, 9);
            dataseta.Add(840957954, 3, 2);
            dataseta.Add(842006530, 4, 5);
            dataseta.Add(843055106, 5, 3);
            dataseta.Add(844103682, 1, 6);
            dataseta.Add(845152258, 2, 9);
            dataseta.Add(846200834, 3, 7);
            dataseta.Add(847249410, 9, 0);
            dataseta.Add(848297986, 0, 3);
            dataseta.Add(849346562, 1, 1);
            dataseta.Add(850395138, 7, 4);
            dataseta.Add(851443714, 8, 7);
            dataseta.Add(852492290, 9, 5);
            dataseta.Add(853540866, 5, 8);
            dataseta.Add(854589442, 6, 1);
            dataseta.Add(855638018, 7, 9);
            dataseta.Add(856686594, 3, 2);
            dataseta.Add(857735170, 4, 5);
            dataseta.Add(858783746, 5, 3);
            dataseta.Add(859832322, 1, 6);
            dataseta.Add(860880898, 2, 9);
            dataseta.Add(861929474, 3, 7);
            dataseta.Add(862978050, 9, 0);
            dataseta.Add(864026626, 0, 3);
            dataseta.Add(865075202, 1, 1);
            dataseta.Add(866123778, 7, 4);
            dataseta.Add(867172354, 8, 7);
            dataseta.Add(868220930, 9, 5);
            dataseta.Add(869269506, 5, 8);
            dataseta.Add(870318082, 6, 1);
            dataseta.Add(871366658, 7, 9);
            dataseta.Add(872415234, 3, 2);
            dataseta.Add(873463810, 4, 5);
            dataseta.Add(874512386, 5, 3);
            dataseta.Add(875560962, 1, 6);
            dataseta.Add(876609538, 2, 9);
            dataseta.Add(877658114, 3, 7);
            dataseta.Add(878706690, 9, 0);
            dataseta.Add(879755266, 0, 3);
            dataseta.Add(880803842, 1, 1);
            dataseta.Add(881852418, 7, 4);
            dataseta.Add(882900994, 8, 7);
            dataseta.Add(883949570, 9, 5);
            dataseta.Add(884998146, 5, 8);
            dataseta.Add(886046722, 6, 1);
            dataseta.Add(887095298, 7, 9);
            dataseta.Add(888143874, 3, 2);
            dataseta.Add(889192450, 4, 5);
            dataseta.Add(890241026, 5, 3);
            dataseta.Add(891289602, 1, 6);
            dataseta.Add(892338178, 2, 9);
            dataseta.Add(893386754, 3, 7);
            dataseta.Add(894435330, 9, 0);
            dataseta.Add(895483906, 0, 3);
            dataseta.Add(896532482, 1, 1);
            dataseta.Add(897581058, 7, 4);
            //dataseta.Add(898629634, 8, 7);
            //dataseta.Add(900000008, 9, 5);
            dataseta.Add(900726786, 5, 8);
            dataseta.Add(901775362, 6, 1);
            dataseta.Add(902823938, 7, 9);
            dataseta.Add(903872514, 3, 2);
            dataseta.Add(904921090, 4, 5);
            dataseta.Add(905969666, 5, 3);
            dataseta.Add(907018242, 1, 6);
            dataseta.Add(908066818, 2, 9);
            dataseta.Add(909115394, 3, 7);
            dataseta.Add(910163970, 9, 0);
            dataseta.Add(911212546, 0, 3);
            dataseta.Add(912261122, 1, 1);
            dataseta.Add(913309698, 7, 4);
            dataseta.Add(914358274, 8, 7);
            dataseta.Add(915406850, 9, 5);
            dataseta.Add(916455426, 5, 8);
            dataseta.Add(917504002, 6, 1);
            dataseta.Add(918552578, 7, 9);
            dataseta.Add(919601154, 3, 2);
            dataseta.Add(920649730, 4, 5);
            dataseta.Add(921698306, 5, 3);
            dataseta.Add(922746882, 1, 6);
            dataseta.Add(923795458, 2, 9);
            dataseta.Add(924844034, 3, 7);
            dataseta.Add(925892610, 9, 0);
            dataseta.Add(926941186, 0, 3);
            dataseta.Add(927989762, 1, 1);
            dataseta.Add(929038338, 7, 4);
            dataseta.Add(930086914, 8, 7);
            dataseta.Add(931135490, 9, 5);
            dataseta.Add(932184066, 5, 8);
            dataseta.Add(933232642, 6, 1);
            dataseta.Add(934281218, 7, 9);
            dataseta.Add(935329794, 3, 2);
            dataseta.Add(936378370, 4, 5);
            dataseta.Add(937426946, 5, 3);
            dataseta.Add(938475522, 1, 6);
            dataseta.Add(939524098, 2, 9);
            dataseta.Add(940572674, 3, 7);
            dataseta.Add(941621250, 9, 0);
            dataseta.Add(942669826, 0, 3);
            dataseta.Add(943718402, 1, 1);
            dataseta.Add(944766978, 7, 4);
            dataseta.Add(945815554, 8, 7);
            dataseta.Add(946864130, 9, 5);
            dataseta.Add(947912706, 5, 8);
            dataseta.Add(948961282, 6, 1);
            dataseta.Add(950009858, 7, 9);
            dataseta.Add(951058434, 3, 2);
            dataseta.Add(952107010, 4, 5);
            dataseta.Add(953155586, 5, 3);
            dataseta.Add(954204162, 1, 6);
            dataseta.Add(955252738, 2, 9);
            dataseta.Add(956301314, 3, 7);
            dataseta.Add(957349890, 9, 0);
            dataseta.Add(958398466, 0, 3);
            dataseta.Add(959447042, 1, 1);
            dataseta.Add(960495618, 7, 4);
            dataseta.Add(961544194, 8, 7);
            dataseta.Add(962592770, 9, 5);
            dataseta.Add(963641346, 5, 8);
            dataseta.Add(964689922, 6, 1);
            dataseta.Add(965738498, 7, 9);
            dataseta.Add(966787074, 3, 2);
            dataseta.Add(967835650, 4, 5);
            dataseta.Add(968884226, 5, 3);
            dataseta.Add(969932802, 1, 6);
            dataseta.Add(970981378, 2, 9);
            dataseta.Add(972029954, 3, 7);
            dataseta.Add(973078530, 9, 0);
            dataseta.Add(974127106, 0, 3);
            dataseta.Add(975175682, 1, 1);
            dataseta.Add(976224258, 7, 4);
            dataseta.Add(977272834, 8, 7);
            dataseta.Add(978321410, 9, 5);
            dataseta.Add(979369986, 5, 8);
            dataseta.Add(980418562, 6, 1);
            dataseta.Add(981467138, 7, 9);
            dataseta.Add(982515714, 3, 2);
            dataseta.Add(983564290, 4, 5);
            dataseta.Add(984612866, 5, 3);
            dataseta.Add(985661442, 1, 6);
            dataseta.Add(986710018, 2, 9);
            dataseta.Add(987758594, 3, 7);
            dataseta.Add(988807170, 9, 0);
            dataseta.Add(989855746, 0, 3);
            dataseta.Add(990904322, 1, 1);
            dataseta.Add(991952898, 7, 4);
            dataseta.Add(993001474, 8, 7);
            dataseta.Add(994050050, 9, 5);
            dataseta.Add(995098626, 5, 8);
            dataseta.Add(996147202, 6, 1);
            dataseta.Add(997195778, 7, 9);
            dataseta.Add(998244354, 3, 2);
                        //1000000009


        }


        public psefibo(int count)
        {
            try
            {

                int elem = (dataseta.Where(p => p.Key < count).Max(p => p.Key));

                if (Related < elem)
                {
                    psefibo.a[0] = dataseta[elem].a;
                    psefibo.a[1] = dataseta[elem].b;
                    psefibo.Related = elem;
                }
            }
            catch { }
            finally { }

            
            ushort oiterc = 10;
            ushort o = oiterc;
            int i;
            while (psefibo.Related + psefibo.baseN < count)
            {

                i = psefibo.Related % psefibo.baseN;
                if (i == 0 && Related > 2)
                {
                    psefibo.a[0] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[psefibo.a.Length - 2]);
#if DEBUG
                    i++;
#endif
                    psefibo.a[1] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[0]);
#if DEBUG
                    i++;
#endif
                    psefibo.Related += 2;
                    o += 2;
                }

#if DEBUG
    Console.WriteLine($@" dataseta.Add({Related}, {a[0]%10}, {a[1]%10});");
#endif

                var start = psefibo.Related % psefibo.baseN;
                for (i = start; i < psefibo.a.Length; ++i)
                { 
                    
                    psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
                       
                    
                    if (o > oiterc)
                    {
                        psefibo.a[i] %= 10;
                        psefibo.a[i - 1] %= 10;
                        o = 0;
                    }
                    ++o;
                }
                psefibo.Related += psefibo.baseN-start;
                
            }
            // херня
            //var end = (count - psefibo.Related) % a.Length < 2 ? (count - psefibo.Related + 2) : (count - psefibo.Related);
            var end = count > a.Length ? count % a.Length : count;

            if (psefibo.Related >= 2)
            {
                switch (psefibo.Related % psefibo.baseN)
                {
                    case 0:
                        a[0] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[psefibo.a.Length - 2]);
                        a[1] = (ushort)(psefibo.a[psefibo.a.Length - 1] + psefibo.a[0]);

#if notiniteddataseta
                        
                        
                            dataseta.Add(Related + 1, a[0], a[1]);
#endif
                        psefibo.Related += 2;
                        o += 2;
                        //i += 2;
                        break;
                    case 1:
                        a[1] = (ushort)(psefibo.a[0] + psefibo.a[a.Length - 1]);
                        psefibo.Related++;
                        o++;
                        break;
                }                
            }
            var start2 = psefibo.Related % psefibo.baseN;
            for (i = start2; i < end ; ++i)
            {                
                
                psefibo.a[i] = (ushort)(psefibo.a[i - 1] + psefibo.a[i - 2]);
                if (o > oiterc)
                {
                    psefibo.a[i] %= 10;
                    psefibo.a[i - 1] %= 10;
                    o = 0;
                }
                ++o;
            }
            Related += i - start2;
            //?????
            //psefibo.count = (ushort)psefibo.a.Length;
        }
        public int LastFibDigit(int n) => (int)psefibo.a[(n - 1) % psefibo.baseN];
    }
    public class Kata
    {
        public static int LastFibDigit(int n)
        {
            var re = (new psefibo(n)).LastFibDigit(n);
            if (re > 9) re %= 10;
            return re;
        }
    }
}
