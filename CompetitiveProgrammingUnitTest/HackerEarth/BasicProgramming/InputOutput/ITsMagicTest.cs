using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class ITsMagicTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestITsMagicBasic()
        {
            int expectedResult = 1;
            int N = 100;
            string numbers = "14 7 8 2 4";
            string numbers2 ="290267 543718 152065 36958 513757 177467 242991 350675 953587 2959 791293 804018 858084 13158 47417 736925 231101 110680 644174 327034 139929 578888 920458 773574 433483 2544 121149 455734 32135 211876 403294 178448 171656 844908 467918 757493 383815 33552 832540 652097 38529 306142 659172 313415 353482 225856 75059 416520 62819 821080 206583 686447 217176 172935 91743 49898 944080 209288 588392 143368 103781 883998 569614 805835 798227 76174 884758 406719 173453 411231 12981 805198 140596 297707 986053 353198 75768 882624 184508 189976 570436 305100 318421 824387 408319 547365 328846 251777 756456 718935 543525 552642 69100 34364 353197 576434 115576 227224 146222 130404";

            int actualResult = ITsMagic.BasicImplementation(N, numbers2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
