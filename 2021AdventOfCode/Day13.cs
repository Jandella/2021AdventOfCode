﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021AdventOfCode
{
    /// <summary>
    /// --- Day 13: Transparent Origami ---
    /// You reach another volcanically active part of the cave.
    /// It would be nice if you could do some kind of thermal imaging so you could tell ahead of time which caves are too hot to safely enter.
    /// </summary>
    public class Day13
    {
        private string _day13input = @"23,123
1116,117
60,18
954,323
1235,226
1123,599
862,231
808,11
982,687
574,248
1041,449
584,105
408,575
594,466
1058,677
23,33
127,862
1305,367
87,220
194,855
706,455
550,241
750,493
922,616
88,861
682,822
487,359
1208,555
579,674
1097,266
1042,400
1043,712
567,151
328,694
494,47
1,623
716,779
574,198
599,890
63,532
818,728
1148,239
104,848
1062,47
1185,516
428,849
1134,519
472,866
1146,207
785,541
75,668
636,306
554,512
644,362
795,623
263,810
805,0
223,409
150,129
858,857
356,571
895,488
962,106
761,151
1121,507
903,786
1097,852
295,726
1118,330
1016,115
930,291
808,435
1123,847
957,243
977,371
492,207
654,229
1285,401
560,401
94,65
1110,110
492,840
922,242
798,248
252,257
333,819
410,855
1218,800
157,582
176,519
1001,390
843,599
572,185
875,9
383,697
310,369
731,220
770,600
638,861
284,599
950,779
927,4
949,729
493,712
105,66
989,527
68,65
743,743
862,103
681,744
855,32
216,519
1054,592
551,854
482,651
1009,651
408,319
967,596
276,23
898,819
654,205
88,413
353,722
1263,407
1140,553
1228,864
435,697
763,505
817,182
301,620
67,203
448,663
575,254
736,78
378,103
154,427
858,37
852,628
1228,870
113,714
929,523
68,737
212,250
893,343
438,71
713,439
636,361
624,599
31,714
579,519
346,533
830,429
718,142
817,574
1048,145
430,71
930,689
161,320
689,486
346,197
75,226
1103,376
114,294
26,854
912,302
452,185
870,327
152,429
1128,890
711,645
509,35
170,553
326,687
1004,788
92,773
907,488
94,493
825,683
823,298
296,74
565,343
1225,837
746,763
566,497
719,138
674,140
565,791
1031,25
756,382
572,750
970,312
661,527
478,631
385,445
940,599
343,596
490,217
242,371
266,779
267,485
437,259
984,709
957,401
908,257
1208,339
472,25
1148,207
80,528
602,155
256,766
300,822
266,331
703,745
1196,824
657,271
105,599
612,373
594,690
25,172
750,829
442,376
1153,582
741,389
818,168
120,103
105,295
497,312
395,467
274,801
672,33
497,582
1200,179
378,455
855,862
1197,714
1059,889
698,344
472,28
1016,779
597,147
899,304
395,469
306,340
1310,431
1146,640
1074,315
500,427
108,166
959,175
1240,302
1260,730
1016,180
1221,103
846,70
480,569
161,350
440,567
199,338
1160,71
1098,518
410,487
922,278
80,590
1284,854
518,182
448,215
818,743
370,295
657,719
1020,84
1193,703
604,791
55,249
801,511
1093,784
813,771
1089,887
1052,487
920,736
176,263
1246,525
460,295
226,493
872,715
820,239
761,131
739,182
556,329
1235,648
437,612
815,410
160,847
1292,82
1235,668
1178,599
892,763
343,148
738,127
1061,249
935,645
433,887
1131,746
925,893
873,730
194,151
1136,17
200,784
744,145
607,697
1240,105
686,329
244,870
700,586
575,640
1109,49
1016,107
518,614
724,65
800,138
224,823
952,341
1230,366
410,821
455,191
1168,218
1016,787
206,7
922,204
120,93
70,275
382,504
247,152
571,712
1150,651
1098,376
92,121
520,11
766,295
161,847
731,648
674,533
1173,59
1206,166
75,815
838,28
547,284
1059,375
873,110
865,639
982,709
213,852
1044,375
1149,126
333,371
1149,847
790,235
790,424
1148,280
430,451
492,743
798,218
930,205
706,791
1039,4
1230,360
1066,463
301,651
1068,819
594,39
1066,487
567,562
202,37
649,771
147,298
1001,607
370,599
1218,773
654,431
5,571
32,474
649,99
596,877
1156,427
1305,323
694,261
1228,30
634,19
87,444
360,740
291,423
1150,847
5,435
199,556
1014,74
300,166
879,409
18,809
266,107
796,848
1228,278
810,651
1148,640
689,802
857,180
251,599
1151,87
403,406
1205,831
358,341
30,372
795,271
775,824
1223,599
279,25
1255,249
907,182
1208,4
1059,22
251,630
515,795
817,798
748,374
80,78
162,726
402,257
68,267
1292,361
142,676
1248,528
120,175
190,376
676,19
470,646
32,698
1263,597
502,667
1149,544
488,495
1134,631
1128,442
1294,481
102,339
403,712
756,512
1205,105
1034,455
698,550
878,196
1059,630
1253,455
709,707
328,872
1146,616
795,520
498,161
492,54
1064,870
388,876
306,788
83,182
852,644
1243,649
962,340
713,893
631,439
837,623
314,312
1094,519
1120,518
540,152
957,722
145,35
1230,590
353,493
564,539
1310,17
1134,263
1171,679
801,859
679,571
390,736
30,522
1222,481
346,362
110,715
556,565
739,712
932,775
818,463
813,562
351,271
760,512
930,603
1009,620
875,197
294,107
800,756
761,295
754,117
985,240
843,123
430,823
1183,862
596,46
873,612
1173,271
49,42
1190,175
575,780
1252,877
493,126
246,814
370,792
636,140
888,513
668,877
1168,676
1278,698
1039,325
515,495
353,274
736,304
801,280
67,691
1173,835
552,787
417,343
1208,611
503,366
1066,95
1285,72
1128,4
547,616
380,205
62,116
952,820
656,431
218,215
716,428
741,421
1034,23
125,516
1248,401
1261,852
540,742
422,381
161,544
395,427
1044,204
268,429
900,407
465,620
989,819
1298,358
266,519
1138,651
607,197
1158,883
452,37
110,599
518,56
713,455
1033,614
1160,765
990,301
982,648
877,763
251,648
845,835
638,481
277,614
525,353
880,778
385,595
1247,810
629,296
351,207
967,148
1021,845
1287,123
1230,78
1309,623
378,775
445,703
85,841
1015,714
328,246
1240,773
838,4
908,665
686,388
996,312
843,151
264,158
714,46
308,85
412,819
957,493
1059,246
377,311
1026,102
711,281
1203,389
925,445
353,401
893,327
610,819
52,801
259,467
388,564
1197,628
100,717
950,714
893,567
266,375
668,536
127,639
808,465
744,397
852,451
55,4
818,239
892,131
1009,274
855,480
518,824
1223,295
33,817
822,495
977,523
1002,697
748,520
1290,467
25,822
251,246
1041,893
1059,488
161,768
816,847
249,249
880,823
408,304
388,690
1248,569
594,652
16,481
1305,459
74,677
136,166
119,518
623,180
458,266
251,519
388,151
708,801
951,266
1196,294
177,336
1158,459
1160,317
1191,471
296,777
1098,250
1063,742
703,597
1101,221
612,344
1190,353
679,439
892,315
1272,485
850,295
64,369
872,519
293,481
535,423
852,3
838,866
1036,291
902,192
1004,340
656,229
258,407
201,845
50,455
1231,192
714,848
330,502
60,428
137,274
381,355
94,519
838,476
1178,71
761,383
584,789
246,575
982,694
437,784
489,488
1235,465
1228,37
679,887
1044,71
895,854
1103,518
855,191
718,752
1212,677
549,579
162,239
1279,180
584,856
1190,599
1059,599
544,715
890,542
1150,47
862,64
246,870
1064,360
586,737
922,330
1230,95
673,831
1000,77
55,697
731,519
928,390
624,372
1087,409
616,485
1101,255
189,620
1019,526
1174,182
562,374
549,131
403,488
403,441
152,883
169,582
1223,220
952,74
607,297
187,599
251,872
621,408
433,7
939,87
85,837
102,283
689,856
82,864
801,35
566,749
410,521
259,873
1093,612
344,677
364,810
85,57
1088,205
1247,362
75,648
705,42
156,553
139,99
808,429
247,332
817,768
902,543
873,259
684,771
502,435
850,487
1235,815
716,652
64,525
120,295
1173,274
574,534
1140,789
525,541
1230,304
92,374
1285,722
113,628
277,280
888,401
688,628
330,392
12,877
402,637
216,375
852,266
903,376
838,869
1205,63
1064,319
817,350
177,560
877,7
1280,295
890,32
510,866
408,360
433,763
764,679
75,79
221,828
410,463
1174,630
954,123
28,571
740,814
587,691
1206,868
217,784
621,861
602,603
1212,217
120,541
432,196
382,390
915,469
67,649
959,719
82,687
502,121
1242,65
514,848
1160,711
862,887
653,271
1218,374
152,569
681,296
957,274
810,427
473,271
411,590
649,123
294,180
982,872
221,66
271,773
550,512
766,179
546,215
159,484
432,56
321,527
689,408
748,800
348,106
70,302
478,183
656,241
458,331
246,80
276,455
1026,743
1250,18
62,528
964,197
340,582
266,115
49,852
575,562
206,887
223,485
1278,180
218,231
107,697
724,157
989,371
908,637
1242,829
32,180
922,652
738,750
137,59
751,245
875,726
82,633
112,7

fold along x=655
fold along y=447
fold along x=327
fold along y=223
fold along x=163
fold along y=111
fold along x=81
fold along y=55
fold along x=40
fold along y=27
fold along y=13
fold along y=6";


        

        public int Quiz1()
        {
            var paper = new TransparentPaper(_day13input);
            //System.Diagnostics.Debug.WriteLine(paper);
            paper.Fold(paper.FoldInstructions.First());
            //System.Diagnostics.Debug.WriteLine(paper);
            return paper.Dots.Count;
        }

        public string Quiz2()
        {
            var paper = new TransparentPaper(_day13input);
            paper.Fold();
            System.Diagnostics.Debug.WriteLine(paper);
            //"BLKJRBAG"
            return paper.ToString();
        }

        
    }

    public class TransparentPaper
    {
        private int _height;
        private int _width;
        public TransparentPaper(string input)
        {
            var lines = input.Split("\n").Select(x => x.Trim()).ToArray();
            var emptyElement = lines.FirstOrDefault(x => string.IsNullOrEmpty(x));
            var indexOfEmpty = Array.IndexOf(lines, emptyElement);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (i < indexOfEmpty)
                {
                    //points
                    var points = line.Split(",");
                    Dots.Add(new TopRightCoordinates
                    {
                        OffsetFromRight = int.Parse(points[0]),
                        OffsetFromTop = int.Parse(points[1])
                    });
                }
                else if (i > indexOfEmpty)
                {
                    //fold instructions
                    var val = line.Replace("fold along ", "");
                    var foldWay = val.Split("=");
                    FoldInstructions.Add(new FoldInstruction
                    {
                        FoldAlong = foldWay[0],
                        FoldLine = int.Parse(foldWay[1])
                    });
                }
            }
            _height = Dots.Max(x => x.OffsetFromTop);
            _width = Dots.Max(x => x.OffsetFromRight);
        }
        public List<TopRightCoordinates> Dots { get; set; } = new List<TopRightCoordinates>();
        public List<FoldInstruction> FoldInstructions { get; set; } = new List<FoldInstruction>();

        public void Fold()
        {
            foreach (var item in FoldInstructions)
            {
                Fold(item);
            }
        }
        public void Fold(FoldInstruction instruction)
        {
            bool foldUp = instruction.FoldAlong == "y";
            List<TopRightCoordinates> newDots;
            if (foldUp)
            {
                newDots = FoldUp(instruction.FoldLine);
            }
            else
            {
                newDots = FoldLeft(instruction.FoldLine);
            }
            Dots = newDots;
        }

        private List<TopRightCoordinates> FoldUp(int line)
        {
            var top = Dots.Where(d => d.OffsetFromTop < line).ToList();
            var bottom = Dots.Where(d => d.OffsetFromTop > line);
            var newDotsFromBottom = new List<TopRightCoordinates>();
            foreach (var dot in bottom)
            {
                var newDot = new TopRightCoordinates
                {
                    OffsetFromRight = dot.OffsetFromRight,
                    OffsetFromTop = line - Math.Abs(dot.OffsetFromTop - line)
                };
                newDotsFromBottom.Add(newDot);
            }
            for (int i = 0; i <= _height; i++)
            {
                for (int j = 0; j <= _width; j++)
                {
                    var dotFromTop = top.FirstOrDefault(d => d.OffsetFromTop == i && d.OffsetFromRight == j);
                    var dotFromBottom = newDotsFromBottom.FirstOrDefault(d => d.OffsetFromTop == i && d.OffsetFromRight == j);
                    if(dotFromTop == null && dotFromBottom != null)
                    {
                        top.Add(dotFromBottom);
                    }
                }
            }
            _height = line - 1; //line count start with 0, height is the actual length from 1 to _height
            return top;
        }

        private List<TopRightCoordinates> FoldLeft(int line)
        {
            var left = Dots.Where(d => d.OffsetFromRight < line).ToList();
            var right = Dots.Where(d => d.OffsetFromRight > line);
            var newDotsFromRight = new List<TopRightCoordinates>();
            foreach (var dot in right)
            {
                var newDot = new TopRightCoordinates
                {
                    OffsetFromRight = line - Math.Abs(dot.OffsetFromRight - line),
                    OffsetFromTop = dot.OffsetFromTop
                };
                newDotsFromRight.Add(newDot);
            }
            for (int i = 0; i <= _height; i++)
            {
                for (int j = 0; j <= _width; j++)
                {
                    var dotFromLeft = left.FirstOrDefault(d => d.OffsetFromTop == i && d.OffsetFromRight == j);
                    var dotFromRight = newDotsFromRight.FirstOrDefault(d => d.OffsetFromTop == i && d.OffsetFromRight == j);
                    if (dotFromLeft == null && dotFromRight != null)
                    {
                        left.Add(dotFromRight);
                    }
                }
            }
            _width = line - 1; //line count start with 0, width is the actual length from 1 to _width
            return left;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= _height; i++)
            {
                for (int j = 0; j <= _width; j++)
                {
                    var dot = Dots.FirstOrDefault(d => d.OffsetFromRight == j && d.OffsetFromTop == i);
                    if(dot == null)
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append('#');
                    }
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }

    public class TopRightCoordinates
    {
        public int OffsetFromRight { get; set; }
        public int OffsetFromTop { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TopRightCoordinates coordinates &&
                   OffsetFromRight == coordinates.OffsetFromRight &&
                   OffsetFromTop == coordinates.OffsetFromTop;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OffsetFromRight, OffsetFromTop);
        }

        public override string ToString()
        {
            return OffsetFromRight + "," + OffsetFromTop;
        }
    }

    public class FoldInstruction
    {
        public string FoldAlong { get; set; } = string.Empty;
        public int FoldLine { get; set; }

        public override string ToString()
        {
            return $"fold along {FoldAlong}={FoldLine}";
        }
    }

}