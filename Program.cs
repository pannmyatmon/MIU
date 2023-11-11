using System;

/*
 int[] a ={ 1, 4, 1, 4, 5, 6};  // 1
int n = 5;
*/
namespace MUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MadHav Array :" + MadhavArray.IsMadhavArray( new int[] { 2, 1, 1, 4, -1, -1  })); // 6

            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(2, 13)); // 6
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(11, 29)); // 6
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(20, 22)); // 0 
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(1, 1)); // 0
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(5, 5)); // 1 
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(6, 2)); // 0
            //Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(-10, 6)); // 3


          //  sameNumberOfFactors_Check test = new sameNumberOfFactors_Check();

            //int n1 = -6, n2 = 21; // -1
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(-6,21)); // -1
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(6, 21)); //1
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(8, 12)); // 0
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(23, 97)); //1
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(0, 1)); // 0
            //Console.WriteLine("sameNumberOfFactors_Check : " + test.SameNumberOfFactors(0, 0)); //1


            

         

            //closestFibonacci_Check test1 = new closestFibonacci_Check();


            //Console.WriteLine("Is Fibonacci : " + test1.closestFibonacci(12));
            //Console.WriteLine("Is Fibonacci : " + test1.closestFibonacci(33));
            //Console.WriteLine("Is Fibonacci : " + test1.closestFibonacci(34));

           /* 
    
            int[] aa ={ 1, 4, 1, 4, 5, 6};  // 1
            int n = 5;
            int[] bb = { 1, 4, 1, 4, 5, 6 }; // 1
            int nn1 = 6;

            int[] cc = { 0, 1, 2, 3, 4, 5, 6, 7, 8 }; //1
            int nn2 = 6;

            int[] d = { 1, 4, 1 }; // 0
            int n3 = 5;

            int[] e = { 8, 8, 8, 8, 7, 7, 7 }; // 0
            int n4 = 15;

            int[] f = { 8, -8, 8, 8, 7, 7, -7 }; // 0
            int n5 = -15;

            int[] g = { 3 }; // 0
            int n6 = 3;

            int[] h = { };  //0
            int n7 = 0; 

           // Console.WriteLine("Is Paired N :" + paired_N.isPairedN(aa,n));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(bb, nn1));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(cc, nn2));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(d, n3));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(e, n4));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(f, n5));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(g, n6));
            //Console.WriteLine("Is Paired N :" + paired_N.isPairedN(h, n7));


            /*

            int[] a = { 9 };//= 0
            int[] b = { 9, 0, 2, -5, 7 }; //=> 2

            int[] c = { 11, 5, 4, 20 }; // = 3

            Console.WriteLine("count square pairs :" + countSquarePairs.countSquarePairsCheck(a));
            Console.WriteLine("count square pairs :" + countSquarePairs.countSquarePairsCheck(b));
            Console.WriteLine("count square pairs :" + countSquarePairs.countSquarePairsCheck(c));
            /*
            int[] a = { 8, 4, 2, 1 }; // 1
            int[] b = { 8, 17, 4, 1 }; // 0
            int[] c = { 8, 4, 1 }; // 0
            int[] d = { 8, 4, 2 }; // 0
            Console.WriteLine("is Guthrie Sequence :" + isGuthrieSequence.isGuthrieSequenceCheck(a));
            Console.WriteLine("is Guthrie Sequence :" + isGuthrieSequence.isGuthrieSequenceCheck(b));
            Console.WriteLine("is Guthrie Sequence :" + isGuthrieSequence.isGuthrieSequenceCheck(c));
            Console.WriteLine("is Guthrie Sequence :" + isGuthrieSequence.isGuthrieSequenceCheck(d));




            /*
            int[] a = { 3, 1, 1, 4 };
            int[] b = { 1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4 };
            int[] c = { 1 };
            int[] d = { };
            int[] e = { 0 };

            Console.WriteLine("stanton Measure :" + stantonMeasure.stantonMeasureCheck(a));
            Console.WriteLine("stanton Measure :" + stantonMeasure.stantonMeasureCheck(b));
            Console.WriteLine("stanton Measure :" + stantonMeasure.stantonMeasureCheck(c));
            Console.WriteLine("stanton Measure :" + stantonMeasure.stantonMeasureCheck(d));
            Console.WriteLine("stanton Measure :" + stantonMeasure.stantonMeasureCheck(e));


            /*

                int[] a=  {2, 7, 3, 4};
                int n1 = 5;

                int[] b = { 7, 3, 3, 2, 4 };
                int n2 = 6;

                int[] c = { 7, 3, 3, 2, 4 };
                int n3 = 10;

                int[] d = { 7, 3, 3, 2, 4 };
                int n4 = 8;

                int[] e = { 7, 3, 3, 2, 4 };
                int n5 = 4;

            Console.WriteLine("is NUnique :" + isNUnique.isNUniqueCheck(a, n1));
            Console.WriteLine("is NUnique :" + isNUnique.isNUniqueCheck(b, n2));
            Console.WriteLine("is NUnique :" + isNUnique.isNUniqueCheck(c, n3));
            Console.WriteLine("is NUnique :" + isNUnique.isNUniqueCheck(d, n4));
            Console.WriteLine("is NUnique :" + isNUnique.isNUniqueCheck(e, n5));




                /*
                int[] a = { 3, 3, 6, 36 };
                int n = 3;
                int[] b = { 4 };
                int m = 2;
                int[] c = { 3, 4, 3, 6, 36 };
                int k = 3;
                int[] d = { 6, 12, 24, 36 };
                int l = 12;
                int[] e = { };
                int ee = 2;
               // Console.WriteLine("is Divisible :" + isDivisible.isDivisibleCheck(a,n));
               // Console.WriteLine("is Divisible :" + isDivisible.isDivisibleCheck(b, m));
                Console.WriteLine("is Divisible :" + isDivisible.isDivisibleCheck(c, k));
               // Console.WriteLine("is Divisible :" + isDivisible.isDivisibleCheck(d, l));
                Console.WriteLine("is Divisible :" + isDivisible.isDivisibleCheck(e, ee));



                /*
                // henry(1, 3) should return 502
                int a = 1, b = 3;
                Console.WriteLine("Perfect Number:" + henry.henryCheck(a,b));
                /*
                int[] a = { 5, -5, 0 };
                int[] b = { 5, -2, 1 };
                Console.WriteLine("is SumSafe :" + isSumSafe.isSumSafeCheck(a));
                Console.WriteLine("is SumSafe :" + isSumSafe.isSumSafeCheck(b));

                /*
                int a = 3;
                int b = 6;
                int c = 5;
                int d = 7;
                int e = 9;
                int f = 15;
                //Console.WriteLine("is Stacked :" + isStacked.isStackedCheck (a));
                Console.WriteLine("is Stacked :" + isStacked.isStackedCheck(b));
                //Console.WriteLine("is Stacked :" + isStacked.isStackedCheck(c));
                //Console.WriteLine("is Stacked :" + isStacked.isStackedCheck(d));
                Console.WriteLine("is Stacked :" + isStacked.isStackedCheck(f));



                /*
                int[] A = { 1, 2, 3, -5, -5, 2, 3, 18 };
                int[] P = { 3, -2, 3 };

                int[] B = { 1, 2, 3, -5, -5, 2, 3, 18 };
                int[] P2 = { 4, -1, 3 };

                Console.WriteLine("Match :" + matches.simplePatternMatch(A, P));

                Console.WriteLine("Match :" + matches.simplePatternMatch(B, P2));
                /*
                int[] a = { 3, 2, 0, 5, 3 };
                int n = 32053;

                int[] b = { 3, 2, 0, 5 };
                int m = 32053;

                Console.WriteLine("reps Equal " + string.Join(',', repsEqual.repsEqualCheck(b,m)));
                /*
                Console.WriteLine("Solve 10: " + string.Join(',' , solve10.solve10Check()));


                /*

                int[] a = { 3, 2, 10, 4, 1, 6, 9 }; // 1
                int[] b = { 2, 10, 4, 1, 6, 9 }; // 0
                int[] c = { 3, 2, 10, 4, 1, 6 }; // 0
                int[] d = { 1, 1, 8, 3, 1, 1 }; // 1
                int[] e = { 9, 15, 6 };  // 1
                int[] f = { 1, 1, 2, 2, 1, 1 }; // 0
                int[] g = { 1, 1, 15 - 1, -1 }; // 1

                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(a));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(b));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(c));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(d));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(e));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(f));
                Console.WriteLine("Is centered 15 : " + Centered15.Centered15Check(g));

                /*

                int[] a = { 22, 19, 10, 10, 19, 22, 22, 10 };// 1
                int[] b = { 1, 2, 2, 2, 2, 2, 2 };           // 0
                int[] c =  { 2, 2, 3, 3, 3, 3, 2, 41, 65};   // 0
                int[] d = { -1, 0, 1, 0, 0, 0 };             // 1
                int[] e = { };                               // 0
                int[] f = { 2147483647, -1, -1, -2147483648 }; // 1
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(a));
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(b));
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(c));
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(d));
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(e));
                Console.WriteLine("Is Trivalent : " + isTrivalent.isTrivalentCheck(f));
                /*
                int[] a = {1, 1, 11, 1111, 1111111};  // 1
                int[] b = { 11, 101, 1111, 11111 };   // 0
                int[] c = { 1 }; // 1
                int[] d = { 11, 22, 13, 34, 125 }; // 0 
                int[] e = { 9, 999, 99999, -9999 }; // 1
                int[] f = { }; // 1

                //Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(a));
                //Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(b));
                //Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(c));
                Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(d));
                Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(e));
                //Console.WriteLine("Is Vanilla : " + isVanilla.isVanillaCheck(f));








               int a = 163;
               int b = 162;
               int c = 69;
               Console.WriteLine("Is Isolated : " + isolated.isolatedCheck(a));
               Console.WriteLine("Is Isolated : " + isolated.isolatedCheck(b));
               Console.WriteLine("Is Isolated : " + isolated.isolatedCheck(c));




               int[] a = { 5, 4, 1, 3, 2 }; // 1
               int[] b = { 18, -1, 3, 4, 0 }; // 0
               int[] c = { 9, 0, 5, 9 }; // 011, 1111, 1111111} i
               int[] d = { 0, 5, 18, 0, 9 }; // 0
               int[] e = { 7, 7, 7, 7 }; //0
               int[] f = { }; // 0
               int[] g = { 1, 2 }; // 0

               Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(a));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(b));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(c));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(d));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(e));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(f));
               //Console.WriteLine("Is Min Max Disjoints : " + isMinMaxDisjoint.isMinMaxDisjointCheck(g));







               /*
               int[] a = { 0, 1 }; // 0

               int[] b = { -1, 2 }; // => 0
               int[] c = { };   // => 1

               int[] d = {5, 5, 5, 5}; // => 1
               int[] e = { 5, 5, 5, 2, 5 }; // => 0
               int[] f = { 2, 3, 3, 99, 99, 99, 99, 99 };

               Console.WriteLine("Is Sqquencial Bounded : " + isSequentiallyBounded.isSequentiallyBoundedCheck(d));






               int n = 12;
               Console.WriteLine("count Representation : " + countRepresentations.countRepresentationsCheck(n));

               /*
            int[] a = { 1, 2, 0, 1, 2, 0, 1, 2 }; // => 1

            int[] b = { 1, 3, 0, 3, 5, 0 }; // => 0

            int[] c = { 1, 2 };

            Console.WriteLine("Is Railroad Tie : " + isRailroadTie.isRailroadTieCheck(c));




            int[] a = { 3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4 };
            int[] c = { -5, -5, -5, -5, -5 };
            int[] d = { 8, 8, 6, 6, -2, -2, -2 };
            int[] b = { 18 };
            Console.WriteLine("Cluster Compression : " + string.Join(',', clusterCompression.clusterCompressionCheck(d)));

            int a = 4; // 624
            int b = 7; // 4762
            int c = 6; // 642
            //  Console.WriteLine("Smallest : " + smallest.smallestCheck(a));


            Queue q = new Queue();
            q.enqueue(10);
            q.enqueue(7);
            q.enqueue(26);
            q.printQueue();
            Console.WriteLine(q.dequeue());
            q.printQueue();



            int[] a = { 11, 4, 9, 2, 8 }; //  => 1
            int[] b = { 2, 4, 6, 8, 11 }; //  => 1
            int[] c = { -2, -4, -6, -8, -11 }; // => 0
            int[] d = { 2 };
            int[] e = { 1 };

            Console.WriteLine("Is Odd Heavy : " + isOddHeavy.isOddHeavyCheck(b));



            int[] a = { 4, 4, 4, 4, 1, 2, 2, 3, 3, 3 };
            int[] b = { 2, 2, 1, 2, 2 };
            int[] c = { };
            int[] d = { 7, 7, 7, 7, 1, 7, 7, 7 };
            Console.WriteLine("Is Pack : " + isPacked.isPackedCheck(d));



            int n = 94;
            Console.WriteLine("Fullness Quotient : " +  fullnessQuotient.fullnessQuotientCheck(n));

            /*
            int[] a = { 8, 4, 9, 0, 3, 1, 2 }; // 0,3,2
            int n = 94;

            int[] b = { 9, -9 };
            int nn = 3;

            int[] c = { 9, -9, 5 };
            int m = 3;

            binaryRepresentation.binaryRepresentationCheck(94, 4);
            Console.WriteLine("Filter Array : " + string.Join(',', filterArray.DoFilterArray(a, n)));

            int f = 34;
            Console.WriteLine("Is Fibonacci : " + closestFibonacci.closestFibonacciCal(f));



            int[] a = { 1, 2, 1 };
            int[] b = { 1, 1, 2, 2, 2, 1, 1 };
            int[] c = { 1, 1, 2, 2, 2, 1, 1, 1 };
            int[] d = {1, 1, 1, 2, 2, 2, 1, 1, 1,3};
            Console.WriteLine("Is 121 Array : " + is121Array.is121ArrayCheck(d));





            int n = 27;
            int p = 3;
            Console.WriteLine("Get exponent: " + getExponent.getExponentCheck(n,p));





            int[] a = { 2, 2, 3, 4, 4, 4, 5};
            int m = 1;
            int n = 5;
            Console.WriteLine("Is Sequence Array: " + isSequencedArray.isSequencedArrayCheck(a,m,n)); ;


            int n = 198;
            int catlen = 2;
            int catlen1 = 3;
            Console.WriteLine("Check Concatenated Sum: " + checkConcatenatedSum.checkConcatenatedSumCal(n,catlen));



            int[] lg = { 1, 2, 3, 4 };
            int[] l = { 18, -12, 9, -10 }; //6

            // 7 because 3 + 4 is larger than either 1 + 2 or 2 + 3
            Console.WriteLine("Largest Adjacent Sum: " + largestAdjacentSum.largestAdjacentSumCheck(l));




            int[] a = { 1, 1, 1, 2, 2, 1, 1, 3 };
            int[] b = { 1, 2, 1, 3 };
            int[] a1 = { 1, 1, 1, 1, 2, 2, 3, 3 };
            int[] b1 = { 1, 2 };
            Console.WriteLine("Match Pattern: " + matchPattern.matchPatternCheck(a,b));


            /*
            int n = 6936;
            int n1 = 14;
            Console.WriteLine("encode Number: " + string.Join(',' , encodeNumber.encodeNumberMethod(n1)));



            int l = 10;
            int l1 = 6936;
            Console.WriteLine("Is largest Prime Factor: " + largestPrimeFactor.largestPrimeFactorCheck(l));



            int[] a = { 0, -3, 0, -4, 0 };
            int[] b = { 2, -3, -2, 6, 9, 18 };
            //3344 
            Console.WriteLine("Is decodeArray from encodedInt: " + decodeArrayfromencodedInt.decodeArray(b));


            //int n = 153;
            int n = 81;
            Console.WriteLine("Is CubePowerFul : " + isCubePowerful.isCubePowerfulCheck(n));



            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int n = 2;
            doIntegerBasedRounding.doIntegerBasedRound(a, n);

            Console.WriteLine("do Integerbased Rounding : " + string.Join(',', a));


            int f = 13;
            Console.WriteLine("Is Fibonacci : " + closestFibonacci.closestFibonacciCheck(f));



            char[] f = {'s', 'i', 't'};
            char[] s = {'i', 't', 's'};
            char[] f1 = { 'b', 'o', 'g' };
            char[] s1 = { 'b', 'o', 'o' };
            Console.WriteLine("Are Anagrams : " + areAnagrams.areAnagramsCheck(f,s));



            /*
            int h = 7;
            int h1 = 5;
            Console.WriteLine("Is Holder : " + isHodder.isHolderCheck(h1));



            int f = 13;
            int f1 = 9;
            Console.WriteLine("Is Fibonacci : " + isFibonacci.isFibonacciCheck(f1));


            int[] A = { 1, 1, 1, 2, 3, -18, 45, 1 };
            int[] A1 = { 1, 1, 3, 4 };
            int[] A2 = { 1, 1, 2, 3, 1, -18, 26, 1 };
            int[] A3 = { };
            Console.WriteLine("One Balance:" + one_balanced.isOneBalanced(A2));


            int n = 50;
            Console.WriteLine("Is Vesuvian :" + isVesuvian.isVesuvianCheck(n));

            int[] z = { 1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12 };
            int[] z1 = { 0, 0, 0, 0, 0 };
            Console.WriteLine("encodeArray :" + isZeroPlentiful.isZeroPlentifulCheck(z1));



            int n = 6936;
            Console.WriteLine("encodeArray :" + string.Join(',', encodeArray.DoEncodedArray(n)));
            // int[] a = { 2, 3, 5, 7, 11 };
            //  int[] b = { 2, 3, 6, 7, 11 };
            //  Console.WriteLine("is 235 Array:" + is235Array.is235ArrayCheck(b));


            /*
            // int[] m = { 5, 2, 10, 3, 15, 1, 2, 2 };
            int[] m = { 1, 2, 10, 3, 15, 1, 2, 2 };
            Console.WriteLine("isMercurial :" + isMercurial.IsMercurialCheck(m));



            int[] p = { 1, 4, 1, 4, 5, 6 };
            //int[] p = { 8, -8, 8, 8, 7, 7, -7 };
            //int n = -15;
            int n = 5;
            Console.WriteLine("Is paired N :" + paired_N.isPairedN(p,n));





            // int t = 10;
            int t = 5;
            Console.WriteLine("Is trianglular :" + isTriangular.isTriangularCheck(t));



            int s = 55;

            Console.WriteLine("Hour Min Second :" + string.Join(',', computeHMS.computerHMSCal(s)));




            int[] m = { 1, 3, 2 };
            int[] m1 = {1, 2, 1, 2, 1, 2, 1,2, 1};



            Console.WriteLine("is Martian Array :" + isMartian.isMartianArray(m1));


            //int[] n = { 1 };
            //int[] n = { -1, 0, 1};
            //int[] n = { 0, 1, 1, 1, 1, 1, 0, 1 };


            int[] n = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

            Console.WriteLine("decodeArray :" + string.Join(',', decodeArray.decodeArrayCheck(n)));


            int number = 25;
            Console.WriteLine("Is digit increase: " + isDigitIncreasing.isDigitIncreasingCheck(number));
            int[] O = { -2, 5, 0, 5, 12 };
            Console.WriteLine("Number of Prime :" + PrimeCount.PrimeCountCheck(2,13));
            int h = 5;
            int ans = isPrimeHappy.isPrimeHappyCheck(h);
            Console.WriteLine("Happy Prime:" + ans);

            int n = -201;
            Console.WriteLine("encodeArray :" +string.Join(',', encodeArray.DoEncodedArray(n)));
            int[] L = { -2, 3, 4, 9 };
            Console.WriteLine("largestDifferenceOfEvens : " + largestDifferenceOfEvens.largestDiffOfEvens(L));
            /*
            int P = 7;  Console.WriteLine("Is Prime Factorial :" + isFactorialPrime.isFactorialPrimeCheck(P));
            Console.WriteLine("Is Prime Factorial J :" + isFactorialPrime.IsFactorialPrime(P));
            int[] A = { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(" Systematically increase :" + isSystematicallyIncrease.IsSystematicallyIncreasing(A));
            int[] I = { 11, 4, 20, 9, 2, 8 };

            Console.WriteLine("Is Inertial :" +isInertial.isInertialCheck(I));
            int[] first = { 1, 8, 3, 2 };
            int[] second = { 4, 2, 6, 1 };
            //{1, 2}

            Console.WriteLine("Common Array :" + commonArray.commonArryCheck( first, second));
            int[] C = { 1, 8, 3, 7, 10, 2 };
            Console.WriteLine("POE :" + A5(C));


            int[] A = { 1, 2, 3, -5, -5, 2, 3, 18 };
            int[] P = { 3, -2, 3 };

            Console.WriteLine("Match :" + Match(A, P));
            Base10.Run(new int[] { 1, 0, 1, 1 }, 2);

            int i = isCentered(new int[] { 2, 1, 3, 4 });
            Console.WriteLine("Is Centered = " + i);

            int d = diffSumEvenOdd(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("diff between Sum Even and sum Odd = " + d);

            string cha = charArrayBasedStartLength(new char[] { 'a', 'b', 'c' }, 1, 2);
            Console.WriteLine("charArrayBasedStartLength = " + cha);
            int reverseInt = reverseIntWithNumericOperator(-321);
            Console.WriteLine("Reverse integer :" + reverseInt);

            int[] FirstArr = { 1, 2, 3, 4 };
            int[] SecondArr = { 1, 3, 5 };
            Console.WriteLine("Common Elements: " + commonElement(FirstArr, SecondArr));
            Console.WriteLine("POE :" + poe(new int[] { 1, 8, 3, 7, 10, 2 }));
            */
        }

        /*
         qs 10
        Consider an array A with n of positive integers. An integer idx is called a POE (point of equilibrium) of A,
        if A[0] + A[1] + … + A[idx – 1] is equal to A[idx + 1] + A[idx + 2] + … + A[n – 1]. Write a function to return 
        POE of an array, if it exists and -1 otherwise. 
        The signature of the function is:
        int f(int[] a)
         */
        // {1, 8, 3, 7, 10, 2}	3 Reason: a[0] + a[1] + a[2] is equal to a[4] + a[5]
        static int A5(int[] a)
        {
            if (a.Length < 3)
                return -1;

            int i = 0;
            int j = a.Length - 1;
            int idx = 1;
            int leftSum = a[i];
            int rightSum = a[j];

            for (int k = 1; k < a.Length - 2; k++)
            {
                if (leftSum < rightSum)
                {
                    i++;
                    leftSum += a[i];
                    idx = i + 1;
                }
                else
                {
                    j--;
                    rightSum += a[j];
                    idx = j - 1;
                }

               
            }

            if (leftSum == rightSum)
                return idx;
            else
                return -1;
           
            
        }
        
        /*
         qs 9
        1. A simple pattern match on the elements of an array A can be defined using another array P.
Each element n of P is negative or positive (never zero) and defines the number of elements in a
sequence in A. The first sequence in A starts at A[0] and its length is defined by P[0]. The second
sequence follows the first sequence and its length is defined by P[1] and so on. Furthermore,
for n in P, if n is positive then the sequence of n elements of A must all be positive. Otherwise
the sequence of abs(n) elements must all be negative. The sum of the absolute values of the
elements of P must be the length of A. For example, consider the array
A = {1, 2, 3, -5, -5, 2, 3, 18}
If P = {3, -2, 3} then A matches P because
i. the first 3 elements of A (1, 2, 3) are positive (P[0] is 3 and is positive),
ii. the next 2 elements of A (-5, -5) are negative (P[1] is -2 and is negative)
iii. and the last 3 elements of A (2, 3, 18) are positive (P[2] is 3 and is positive)
Notice that the absolute values of the elements of P sum to 8 which is the length of A.
         */

        //A = {1, 2, 3, -5, -5, 2, 3, 18} /   P = {3, -2, 3}
        public static int Match(int[] A, int[] P)
        {
            //check if P total is equal to A length
            var pTotal = 0;

            for (var p = 0; p < P.Length; p++)
                pTotal += P[p] < 0 ? -P[p] : P[p];

            //check total and sum same or not
            if (pTotal != A.Length)
                return 0;


            var curr = 0;

            for (var p = 0; p < P.Length; p++)
            {
                var pVal = P[p];
                var pAbs = pVal < 0 ? -pVal : pVal;
                var isNegative = pVal < 0;

                // pAbs = 3 // A = {1, 2, 3, -5, -5, 2, 3, 18}
               
                for (var a = 0; a < pAbs; a++)
                {
                    //if (isNegative != (A[a] < 0))
                    //    return 0;

                    if (isNegative)
                    {
                        if (A[curr] > 0)
                            return 0;
                    }
                    else
                    {
                        if (A[curr] < 0)
                            return 0;
                    }


                    curr++;
                }
            }



            return 1;
        }
    

   

        /*
         * qs 8
         */
        static int a4(int n)
        {
            int sign = 1;
            if (n == 0) return 0;
            if (n < 0)
            {
                sign = -1;
                n = -n;
            }
            int reverse = 0;
            while (n != 0)
            {
                reverse = (reverse * 10) + (n % 10);
                n /= 10;
            }
            return sign * reverse;
        }



        /*
         * 
         * 
         * 
         
         Islegal ( 7)
         */
      

        /*
         Question6
         Consider an array A with n of positive integers. An integer idx is called
a POE (point of equilibrium) of A, if A[0]+A[1]+...+A[idx-1] is equal to A[idx+1]+A[idx+2]+...+A[n-1].
Write a function to return POE of an array, if it exists and -1 otherwise.

The signature of the function is:
int f(int[] a)
         */
        static int poe(int[] numbers)
          {
            if (numbers.Length < 3) return -1;

            int i = 0;
            int j = numbers.Length - 1;
            int idx = 1;

            int leftSum = numbers[i];
            int rightSum = numbers[j];

            for (int k = 0; k < numbers.Length - 2; k++)
            {
                if (leftSum < rightSum)
                {
                    i++;
                    leftSum += numbers[i];
                    idx = i + 1;
                }
                else
                {
                    j--;
                    rightSum += numbers[j];
                    idx = j - 1;
                }

                if (leftSum == rightSum)
                {
                    return idx;
                }
            }
            return -1;
           }

        /*
      +  Question 5
Write a function to return an array containing all elements common to two
given arrays containing distinct positive integers.You should not use any inbuilt
methods. You are allowed to use any number of arrays.

The signature of the function is:
int[] f(int[] first, int[] second)
        */

        static String commonElement(int[] firstArray, int[] secondArray)
        {
            int count = 0;
            if (firstArray == null || secondArray == null)
            {
                return null; 
            }

            if (firstArray.Length == 0 || secondArray.Length == 0)
            {
                int[] _commonElements = new int[count];
                return string.Join(',', _commonElements);

            }
            int min = (firstArray.Length < secondArray.Length) ? firstArray.Length : secondArray.Length;

            int[] firstClone, secondClone;

            if (min == firstArray.Length)
            {
                firstClone = firstArray;
                secondClone = secondArray;
            }
            else
            {
                firstClone = secondArray;
                secondClone = firstArray;
            }

            int[] reArray = new int[min];
          
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        reArray[count] = firstArray[i];
                        count++;

                    }
                }

            }
            int[] commonElements = new int[count];
            for (int i = 0; i < commonElements.Length; i++)
            {
                commonElements[i] = reArray[i];
            }

            return string.Join(',', commonElements);
        }

        #region
        /* Question 1
        An array with an odd number of elements is said to be centered
        if all elements(except the middle one) are strictly greater than the value
        of the middle element.Note that only arrays with an odd number of elements
        have a middle element.Write a function that accepts an integer array and 
        returns 1 if it is a centered array, otherwise it returns 0.
             */
        #endregion

        //static int isCentered(int[] items)
        //{
        //    if (items.Length == 0 || items.Length % 2 == 0)
        //        return 0;

        //    int midIndex = items.Length / 2;
        //    int middleItem = items[midIndex];
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        if (i != midIndex && middleItem >= items[i])
        //        {
        //            return 0;
        //        }
              
        //    }

        //    return 1;
        //}

        /*  Question 2
        Write a function that takes an array of integers as an argument and returns a
        value based on the sums of the even and odd numbers in the array.
        Let X = the sum of the odd numbers in the array and 
        let Y = the sum of the even numbers.
        The function should return X - Y
        The signature of the function is:
        int f(int[] a)
        */

        static int diffSumEvenOdd(int[] items)
        {
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] % 2 == 0)
                    sumEven += items[i];
                else
                    sumOdd += items[i];
            }
            return sumOdd - sumEven;
        }

        /*Question 3

Write a function that accepts a character array, a zero-based start position and a length. 
It should return a character array containing lengthCharacters starting with the startCharacter of the input array. 
The function should do error checking on the start position and the length and return null if the either value is not legal.

The function signature is:
char[] f(char[] a, int start, int len)*/

        static String charArrayBasedStartLength(char[] chars, int start, int len)
        {
            if (len < 0 || start < 0 || start + len - 1 >= chars.Length)
                return null;
            char[] newChars = new char[len];
            for (int i = start, j = 0; j < len; i++, j++)
            {
                newChars[j] = chars[i];
            }
            return string.Join(", ", newChars);
        }

        /*
         Question 4
Write a function to reverse an integer using numeric operators and without
using any arrays or other data structures.

The signature of the function is:
int f(int n)
         */
        static int reverseIntWithNumericOperator(int number)
        {
            int sign = 1;
            if (number == 0)
                return 0;
            if (number < 0)
            {
                sign = -1;
                number = -number;
            }
            int reverse = 0;
            while (number != 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number /= 10;
            }
            return sign * reverse;
        }


    }
}
