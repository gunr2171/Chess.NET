﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Tests
{
    [TestFixture]
    public static class ChessGameTests
    {
        static readonly ChessPiece kw = new ChessPiece(Piece.King, Player.White);
        static readonly ChessPiece kb = new ChessPiece(Piece.King, Player.Black);
        static readonly ChessPiece qw = new ChessPiece(Piece.Queen, Player.White);
        static readonly ChessPiece qb = new ChessPiece(Piece.Queen, Player.Black);
        static readonly ChessPiece rw = new ChessPiece(Piece.Rook, Player.White);
        static readonly ChessPiece rb = new ChessPiece(Piece.Rook, Player.Black);
        static readonly ChessPiece nw = new ChessPiece(Piece.Knight, Player.White);
        static readonly ChessPiece nb = new ChessPiece(Piece.Knight, Player.Black);
        static readonly ChessPiece bw = new ChessPiece(Piece.Bishop, Player.White);
        static readonly ChessPiece bb = new ChessPiece(Piece.Bishop, Player.Black);
        static readonly ChessPiece pw = new ChessPiece(Piece.Pawn, Player.White);
        static readonly ChessPiece pb = new ChessPiece(Piece.Pawn, Player.Black);
        static readonly ChessPiece o = ChessPiece.None;

        [Test]
        public static void TestArrayGetting()
        {
            ChessGame cb = new ChessGame();
            int one = (int)Rank.One;
            int two = (int)Rank.Two;
            int three = (int)Rank.Three;
            int four = (int)Rank.Four;
            int five = (int)Rank.Five;
            int six = (int)Rank.Six;
            int seven = (int)Rank.Seven;
            int eight = (int)Rank.Eight;
            int a = (int)File.A;
            int b = (int)File.B;
            int c = (int)File.C;
            int d = (int)File.D;
            int e = (int)File.E;
            int f = (int)File.F;
            int g = (int)File.G;
            int h = (int)File.H;
            Assert.AreEqual(rw, cb.GetBoard()[one][a]);
            Assert.AreEqual(nw, cb.GetBoard()[one][b]);
            Assert.AreEqual(bw, cb.GetBoard()[one][c]);
            Assert.AreEqual(qw, cb.GetBoard()[one][d]);
            Assert.AreEqual(kw, cb.GetBoard()[one][e]);
            Assert.AreEqual(bw, cb.GetBoard()[one][f]);
            Assert.AreEqual(nw, cb.GetBoard()[one][g]);
            Assert.AreEqual(rw, cb.GetBoard()[one][h]);
            Assert.AreEqual(pw, cb.GetBoard()[two][a]);
            Assert.AreEqual(pw, cb.GetBoard()[two][b]);
            Assert.AreEqual(pw, cb.GetBoard()[two][c]);
            Assert.AreEqual(pw, cb.GetBoard()[two][d]);
            Assert.AreEqual(pw, cb.GetBoard()[two][e]);
            Assert.AreEqual(pw, cb.GetBoard()[two][f]);
            Assert.AreEqual(pw, cb.GetBoard()[two][g]);
            Assert.AreEqual(pw, cb.GetBoard()[two][h]);
            Assert.AreEqual(o, cb.GetBoard()[three][a]);
            Assert.AreEqual(o, cb.GetBoard()[three][b]);
            Assert.AreEqual(o, cb.GetBoard()[three][c]);
            Assert.AreEqual(o, cb.GetBoard()[three][d]);
            Assert.AreEqual(o, cb.GetBoard()[three][e]);
            Assert.AreEqual(o, cb.GetBoard()[three][f]);
            Assert.AreEqual(o, cb.GetBoard()[three][g]);
            Assert.AreEqual(o, cb.GetBoard()[three][h]);
            Assert.AreEqual(o, cb.GetBoard()[four][a]);
            Assert.AreEqual(o, cb.GetBoard()[four][b]);
            Assert.AreEqual(o, cb.GetBoard()[four][c]);
            Assert.AreEqual(o, cb.GetBoard()[four][d]);
            Assert.AreEqual(o, cb.GetBoard()[four][e]);
            Assert.AreEqual(o, cb.GetBoard()[four][f]);
            Assert.AreEqual(o, cb.GetBoard()[four][g]);
            Assert.AreEqual(o, cb.GetBoard()[four][h]);
            Assert.AreEqual(o, cb.GetBoard()[five][a]);
            Assert.AreEqual(o, cb.GetBoard()[five][b]);
            Assert.AreEqual(o, cb.GetBoard()[five][c]);
            Assert.AreEqual(o, cb.GetBoard()[five][d]);
            Assert.AreEqual(o, cb.GetBoard()[five][e]);
            Assert.AreEqual(o, cb.GetBoard()[five][f]);
            Assert.AreEqual(o, cb.GetBoard()[five][g]);
            Assert.AreEqual(o, cb.GetBoard()[five][h]);
            Assert.AreEqual(o, cb.GetBoard()[six][a]);
            Assert.AreEqual(o, cb.GetBoard()[six][b]);
            Assert.AreEqual(o, cb.GetBoard()[six][c]);
            Assert.AreEqual(o, cb.GetBoard()[six][d]);
            Assert.AreEqual(o, cb.GetBoard()[six][e]);
            Assert.AreEqual(o, cb.GetBoard()[six][f]);
            Assert.AreEqual(o, cb.GetBoard()[six][g]);
            Assert.AreEqual(o, cb.GetBoard()[six][h]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][a]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][b]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][c]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][d]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][e]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][f]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][g]);
            Assert.AreEqual(pb, cb.GetBoard()[seven][h]);
            Assert.AreEqual(rb, cb.GetBoard()[eight][a]);
            Assert.AreEqual(nb, cb.GetBoard()[eight][b]);
            Assert.AreEqual(bb, cb.GetBoard()[eight][c]);
            Assert.AreEqual(qb, cb.GetBoard()[eight][d]);
            Assert.AreEqual(kb, cb.GetBoard()[eight][e]);
            Assert.AreEqual(bb, cb.GetBoard()[eight][f]);
            Assert.AreEqual(nb, cb.GetBoard()[eight][g]);
            Assert.AreEqual(rb, cb.GetBoard()[eight][h]);
        }

        [Test]
        public static void TestGetPieceAt()
        {
            ChessGame cb = new ChessGame();
            Rank one = Rank.One;
            Rank two = Rank.Two;
            Rank three = Rank.Three;
            Rank four = Rank.Four;
            Rank five = Rank.Five;
            Rank six = Rank.Six;
            Rank seven = Rank.Seven;
            Rank eight = Rank.Eight;
            File a = File.A;
            File b = File.B;
            File c = File.C;
            File d = File.D;
            File e = File.E;
            File f = File.F;
            File g = File.G;
            File h = File.H;
            Assert.AreEqual(rw, cb.GetPieceAt(a, one));
            Assert.AreEqual(nw, cb.GetPieceAt(b, one));
            Assert.AreEqual(bw, cb.GetPieceAt(c, one));
            Assert.AreEqual(qw, cb.GetPieceAt(d, one));
            Assert.AreEqual(kw, cb.GetPieceAt(e, one));
            Assert.AreEqual(bw, cb.GetPieceAt(f, one));
            Assert.AreEqual(nw, cb.GetPieceAt(g, one));
            Assert.AreEqual(rw, cb.GetPieceAt(h, one));
            Assert.AreEqual(pw, cb.GetPieceAt(a, two));
            Assert.AreEqual(pw, cb.GetPieceAt(b, two));
            Assert.AreEqual(pw, cb.GetPieceAt(c, two));
            Assert.AreEqual(pw, cb.GetPieceAt(d, two));
            Assert.AreEqual(pw, cb.GetPieceAt(e, two));
            Assert.AreEqual(pw, cb.GetPieceAt(f, two));
            Assert.AreEqual(pw, cb.GetPieceAt(g, two));
            Assert.AreEqual(pw, cb.GetPieceAt(h, two));
            Assert.AreEqual(o, cb.GetPieceAt(a, three));
            Assert.AreEqual(o, cb.GetPieceAt(b, three));
            Assert.AreEqual(o, cb.GetPieceAt(c, three));
            Assert.AreEqual(o, cb.GetPieceAt(d, three));
            Assert.AreEqual(o, cb.GetPieceAt(e, three));
            Assert.AreEqual(o, cb.GetPieceAt(f, three));
            Assert.AreEqual(o, cb.GetPieceAt(g, three));
            Assert.AreEqual(o, cb.GetPieceAt(h, three));
            Assert.AreEqual(o, cb.GetPieceAt(a, four));
            Assert.AreEqual(o, cb.GetPieceAt(b, four));
            Assert.AreEqual(o, cb.GetPieceAt(c, four));
            Assert.AreEqual(o, cb.GetPieceAt(d, four));
            Assert.AreEqual(o, cb.GetPieceAt(e, four));
            Assert.AreEqual(o, cb.GetPieceAt(f, four));
            Assert.AreEqual(o, cb.GetPieceAt(g, four));
            Assert.AreEqual(o, cb.GetPieceAt(h, four));
            Assert.AreEqual(o, cb.GetPieceAt(a, five));
            Assert.AreEqual(o, cb.GetPieceAt(b, five));
            Assert.AreEqual(o, cb.GetPieceAt(c, five));
            Assert.AreEqual(o, cb.GetPieceAt(d, five));
            Assert.AreEqual(o, cb.GetPieceAt(e, five));
            Assert.AreEqual(o, cb.GetPieceAt(f, five));
            Assert.AreEqual(o, cb.GetPieceAt(g, five));
            Assert.AreEqual(o, cb.GetPieceAt(h, five));
            Assert.AreEqual(o, cb.GetPieceAt(a, six));
            Assert.AreEqual(o, cb.GetPieceAt(b, six));
            Assert.AreEqual(o, cb.GetPieceAt(c, six));
            Assert.AreEqual(o, cb.GetPieceAt(d, six));
            Assert.AreEqual(o, cb.GetPieceAt(e, six));
            Assert.AreEqual(o, cb.GetPieceAt(f, six));
            Assert.AreEqual(o, cb.GetPieceAt(g, six));
            Assert.AreEqual(o, cb.GetPieceAt(h, six));
            Assert.AreEqual(pb, cb.GetPieceAt(a, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(b, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(c, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(d, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(e, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(f, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(g, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(h, seven));
            Assert.AreEqual(rb, cb.GetPieceAt(a, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(b, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(c, eight));
            Assert.AreEqual(qb, cb.GetPieceAt(d, eight));
            Assert.AreEqual(kb, cb.GetPieceAt(e, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(f, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(g, eight));
            Assert.AreEqual(rb, cb.GetPieceAt(h, eight));
        }

        [Test]
        public static void TestCustomInitialize()
        {
            Rank one = Rank.One;
            Rank two = Rank.Two;
            Rank three = Rank.Three;
            Rank four = Rank.Four;
            Rank five = Rank.Five;
            Rank six = Rank.Six;
            Rank seven = Rank.Seven;
            Rank eight = Rank.Eight;
            File a = File.A;
            File b = File.B;
            File c = File.C;
            File d = File.D;
            File e = File.E;
            File f = File.F;
            File g = File.G;
            File h = File.H;
            ChessPiece[][] board = new ChessPiece[8][]
            {
                new[] { rb, o, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { o, o, nb, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, pw, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, pw, pw, pw, o, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Assert.AreEqual(rw, cb.GetPieceAt(a, one));
            Assert.AreEqual(nw, cb.GetPieceAt(b, one));
            Assert.AreEqual(bw, cb.GetPieceAt(c, one));
            Assert.AreEqual(qw, cb.GetPieceAt(d, one));
            Assert.AreEqual(kw, cb.GetPieceAt(e, one));
            Assert.AreEqual(bw, cb.GetPieceAt(f, one));
            Assert.AreEqual(nw, cb.GetPieceAt(g, one));
            Assert.AreEqual(rw, cb.GetPieceAt(h, one));
            Assert.AreEqual(pw, cb.GetPieceAt(a, two));
            Assert.AreEqual(pw, cb.GetPieceAt(b, two));
            Assert.AreEqual(pw, cb.GetPieceAt(c, two));
            Assert.AreEqual(pw, cb.GetPieceAt(d, two));
            Assert.AreEqual(o, cb.GetPieceAt(e, two));
            Assert.AreEqual(pw, cb.GetPieceAt(f, two));
            Assert.AreEqual(pw, cb.GetPieceAt(g, two));
            Assert.AreEqual(pw, cb.GetPieceAt(h, two));
            Assert.AreEqual(o, cb.GetPieceAt(a, three));
            Assert.AreEqual(o, cb.GetPieceAt(b, three));
            Assert.AreEqual(o, cb.GetPieceAt(c, three));
            Assert.AreEqual(o, cb.GetPieceAt(d, three));
            Assert.AreEqual(o, cb.GetPieceAt(e, three));
            Assert.AreEqual(o, cb.GetPieceAt(f, three));
            Assert.AreEqual(o, cb.GetPieceAt(g, three));
            Assert.AreEqual(o, cb.GetPieceAt(h, three));
            Assert.AreEqual(o, cb.GetPieceAt(a, four));
            Assert.AreEqual(o, cb.GetPieceAt(b, four));
            Assert.AreEqual(o, cb.GetPieceAt(c, four));
            Assert.AreEqual(o, cb.GetPieceAt(d, four));
            Assert.AreEqual(pw, cb.GetPieceAt(e, four));
            Assert.AreEqual(o, cb.GetPieceAt(f, four));
            Assert.AreEqual(o, cb.GetPieceAt(g, four));
            Assert.AreEqual(o, cb.GetPieceAt(h, four));
            Assert.AreEqual(o, cb.GetPieceAt(a, five));
            Assert.AreEqual(o, cb.GetPieceAt(b, five));
            Assert.AreEqual(o, cb.GetPieceAt(c, five));
            Assert.AreEqual(o, cb.GetPieceAt(d, five));
            Assert.AreEqual(o, cb.GetPieceAt(e, five));
            Assert.AreEqual(o, cb.GetPieceAt(f, five));
            Assert.AreEqual(o, cb.GetPieceAt(g, five));
            Assert.AreEqual(o, cb.GetPieceAt(h, five));
            Assert.AreEqual(o, cb.GetPieceAt(a, six));
            Assert.AreEqual(o, cb.GetPieceAt(b, six));
            Assert.AreEqual(cb.GetPieceAt(c, six), nb);
            Assert.AreEqual(o, cb.GetPieceAt(d, six));
            Assert.AreEqual(o, cb.GetPieceAt(e, six));
            Assert.AreEqual(o, cb.GetPieceAt(f, six));
            Assert.AreEqual(o, cb.GetPieceAt(g, six));
            Assert.AreEqual(o, cb.GetPieceAt(h, six));
            Assert.AreEqual(pb, cb.GetPieceAt(a, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(b, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(c, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(d, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(e, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(f, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(g, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(h, seven));
            Assert.AreEqual(rb, cb.GetPieceAt(a, eight));
            Assert.AreEqual(o, cb.GetPieceAt(b, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(c, eight));
            Assert.AreEqual(qb, cb.GetPieceAt(d, eight));
            Assert.AreEqual(kb, cb.GetPieceAt(e, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(f, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(g, eight));
            Assert.AreEqual(rb, cb.GetPieceAt(h, eight));
        }

        [Test]
        public static void TestValidMoveWhitePawn()
        {
            ChessGame cb = new ChessGame();

            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveWhitePawn_TwoSteps()
        {
            ChessGame cb = new ChessGame();

            Move move1 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Four), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveWhitePawn_Capture()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);
            Move move2 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Four), new Position(File.D, Rank.Five), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhitePawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Four), new Position(File.E, Rank.Five), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Five), Player.Black);
            Move move5 = new Move(new Position(File.E, Rank.Five), new Position(File.D, Rank.Six), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.True(cb.IsValidMove(move5));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Four), new Position(File.E, Rank.Five), Player.White);
            Move move4 = new Move(new Position(File.H, Rank.Seven), new Position(File.H, Rank.Five), Player.Black);
            Move move5 = new Move(new Position(File.E, Rank.Five), new Position(File.D, Rank.Six), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.False(cb.IsValidMove(move5));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_NoCapture()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);
            Move move2 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Four), new Position(File.D, Rank.Five), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_TwoStepsBlockingPiece()
        {
            ChessPiece[][] board = new ChessPiece[8][]
            {
                new[] { kw, o, kb, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, pb, o, o, o },
                new[] { o, o, o, o, pw, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);

            Assert.False(cb.IsValidMove(move), "move should be invalid");

        }

        [Test]
        public static void TestInvalidMoveWhitePawn_TwoStepsNotOnRankTwo()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Three), new Position(File.E, Rank.Five), Player.White);

            cb.ApplyMove(move1, true);

            Assert.False(cb.IsValidMove(move2), "move2 should be invalid");
        }

        [Test]
        public static void TestValidMoveWhiteKnight()
        {
            ChessGame cb = new ChessGame();

            Move move1 = new Move(new Position(File.B, Rank.One), new Position(File.C, Rank.Three), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteBishopC()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.C, Rank.One), new Position(File.F, Rank.Four), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteBishopF()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.F, Rank.One), new Position(File.C, Rank.Four), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteRookA()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.A, Rank.One), new Position(File.A, Rank.Two), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteRookH()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.One), new Position(File.H, Rank.Two), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteQueenDiagonal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.One), new Position(File.H, Rank.Five), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteQueenVertical()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.One), new Position(File.D, Rank.Two), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteQueenHorizontal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.B, Rank.One), new Position(File.C, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.B, Rank.Seven), new Position(File.B, Rank.Six), Player.Black);
            Move move5 = new Move(new Position(File.C, Rank.One), new Position(File.D, Rank.Two), Player.White);
            Move move6 = new Move(new Position(File.C, Rank.Seven), new Position(File.C, Rank.Six), Player.Black);
            Move move7 = new Move(new Position(File.D, Rank.One), new Position(File.C, Rank.One), Player.White);
            Move move8 = new Move(new Position(File.D, Rank.One), new Position(File.B, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);

            Assert.True(cb.IsValidMove(move7), "move7 should be valid");
            Assert.True(cb.IsValidMove(move8), "move8 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKingDiagonal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.F, Rank.Two), new Position(File.F, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.One), new Position(File.F, Rank.Two), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKingHorizontal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.One), new Position(File.D, Rank.Two), Player.White);
            Move move4 = new Move(new Position(File.H, Rank.Seven), new Position(File.H, Rank.Six), Player.Black);
            Move move5 = new Move(new Position(File.E, Rank.One), new Position(File.D, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.True(cb.IsValidMove(move5), "move5 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKingVertical()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.One), new Position(File.E, Rank.Two), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKing_KingsideCastling()
        {
            ChessPiece[][] board = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKing_QueensideCastling()
        {
            ChessPiece[][] board = new ChessPiece[8][]
            {
                new[] { o, o, o, kb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_WouldPassThroughCheck()
        {
            ChessPiece[][] board = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, rb, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_WouldPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, rb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestValidMoveWhiteKing_KingsideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveWhiteKing_QueensideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, rb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_BlockingPiece1()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, rw, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece1()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, kb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, rw, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_BlockingPiece2()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, rw, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece2()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, rw, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece3()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, rw, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_NoRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_NoRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_RookMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.H, Rank.One), new Position(File.H, Rank.Two), Player.White);
            Move move2 = new Move(new Position(File.B, Rank.Eight), new Position(File.B, Rank.Seven), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_RookMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.A, Rank.One), new Position(File.A, Rank.Two), Player.White);
            Move move2 = new Move(new Position(File.B, Rank.Eight), new Position(File.B, Rank.Seven), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_KingMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.D, Rank.One), Player.White);
            Move move2 = new Move(new Position(File.B, Rank.Eight), new Position(File.B, Rank.Seven), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.One), new Position(File.F, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_KingMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move1 = new Move(new Position(File.E, Rank.One), new Position(File.D, Rank.One), Player.White);
            Move move2 = new Move(new Position(File.B, Rank.Eight), new Position(File.B, Rank.Seven), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.One), new Position(File.B, Rank.One), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestValidMoveBlackPawn()
        {
            ChessGame cb = new ChessGame();
            cb.ApplyMove(new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White), true);

            Move move1 = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Six), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackPawn_TwoSteps()
        {
            ChessGame cb = new ChessGame();
            cb.ApplyMove(new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White), true);

            Move move1 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Five), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackPawn_Capture()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Four), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Five), new Position(File.D, Rank.Four), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackPawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.B, Rank.One), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Five), new Position(File.E, Rank.Four), Player.Black);
            Move move5 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Four), Player.White);
            Move move6 = new Move(new Position(File.E, Rank.Four), new Position(File.D, Rank.Three), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.True(cb.IsValidMove(move6));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.B, Rank.One), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Five), new Position(File.E, Rank.Four), Player.Black);
            Move move5 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Four), Player.White);
            Move move6 = new Move(new Position(File.E, Rank.Four), new Position(File.D, Rank.Three), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.False(cb.IsValidMove(move6));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_NoCapture()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Five), new Position(File.D, Rank.Four), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.False(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_TwoStepsBlockingPiece()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, pb, o, o, o },
                new[] { o, o, o, o, pw, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { kw, o, kb, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);

            Assert.False(cb.IsValidMove(move), "move should be invalid");

        }

        [Test]
        public static void TestInvalidMoveBlackPawn_TwoStepsNotOnRankSeven()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Six), new Position(File.E, Rank.Four), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.False(cb.IsValidMove(move4), "move4 should be invalid");
        }

        [Test]
        public static void TestValidMoveBlackKnight()
        {
            ChessGame cb = new ChessGame();
            cb.ApplyMove(new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White), true);

            Move move1 = new Move(new Position(File.B, Rank.Eight), new Position(File.C, Rank.Six), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackBishopC()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.C, Rank.Eight), new Position(File.F, Rank.Five), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackBishopF()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.F, Rank.Eight), new Position(File.C, Rank.Five), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackQueenDiagonal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Eight), new Position(File.H, Rank.Four), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackQueenVertical()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Eight), new Position(File.D, Rank.Seven), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackQueenHorizontal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.B, Rank.Eight), new Position(File.C, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.B, Rank.Two), new Position(File.B, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Six), Player.Black);
            Move move5 = new Move(new Position(File.C, Rank.Two), new Position(File.C, Rank.Three), Player.White);
            Move move6 = new Move(new Position(File.C, Rank.Eight), new Position(File.D, Rank.Seven), Player.Black);
            Move move7 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Three), Player.White);
            Move move8 = new Move(new Position(File.D, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);
            Move move9 = new Move(new Position(File.D, Rank.Eight), new Position(File.B, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);
            cb.ApplyMove(move7, true);

            Assert.True(cb.IsValidMove(move8), "move8 should be valid");
            Assert.True(cb.IsValidMove(move9), "move9 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKingDiagonal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.F, Rank.Seven), new Position(File.F, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Eight), new Position(File.F, Rank.Seven), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKingHorizontal()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Eight), new Position(File.D, Rank.Seven), Player.Black);
            Move move5 = new Move(new Position(File.B, Rank.Two), new Position(File.B, Rank.Three), Player.White);
            Move move6 = new Move(new Position(File.E, Rank.Eight), new Position(File.D, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.True(cb.IsValidMove(move6), "move6 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKingVertical()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.H, Rank.Two), new Position(File.H, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Eight), new Position(File.E, Rank.Seven), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKing_KingsideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKing_QueensideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_WouldPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, rw, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_WouldPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, rw, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestValidMoveBlackKing_KingsideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestValidMoveBlackKing_QueensideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, rw, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.True(cb.IsValidMove(move1), "move1 should be valid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_BlockingPiece1()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, rb, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o}
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece1()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, rb, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_BlockingPiece2()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, rb, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece2()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, rb, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece3()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, rb, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_NoRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_NoRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_RookMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kw, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.H, Rank.Eight), new Position(File.H, Rank.Seven), Player.Black);
            Move move2 = new Move(new Position(File.B, Rank.One), new Position(File.B, Rank.Two), Player.White);
            Move move3 = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_RookMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kw, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.A, Rank.Eight), new Position(File.A, Rank.Seven), Player.Black);
            Move move2 = new Move(new Position(File.B, Rank.One), new Position(File.B, Rank.Two), Player.White);
            Move move3 = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_KingMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kw, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.D, Rank.Eight), Player.Black);
            Move move2 = new Move(new Position(File.B, Rank.One), new Position(File.B, Rank.Two), Player.White);
            Move move3 = new Move(new Position(File.D, Rank.Eight), new Position(File.F, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_KingMoved()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kw, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.E, Rank.Eight), new Position(File.D, Rank.Eight), Player.Black);
            Move move2 = new Move(new Position(File.B, Rank.One), new Position(File.B, Rank.Two), Player.White);
            Move move3 = new Move(new Position(File.D, Rank.Eight), new Position(File.B, Rank.Eight), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestInvalidMoveWhite_WouldBeInCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { kw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, qb },
                new[] { pw, o, o, pb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move = new Move(new Position(File.A, Rank.Eight), new Position(File.A, Rank.Seven), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveWhite_WouldBeCheckmated()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, rb },
                new[] { o, o, o, kw, nb, o, rb, o }
            };

            ChessGame cb = new ChessGame(board, Player.White);
            Move move = new Move(new Position(File.D, Rank.One), new Position(File.E, Rank.One), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveWhiteRook_NoPassThrough()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, pw, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, kw, o, kb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            Move move = new Move(new Position(File.A, Rank.Seven), new Position(File.G, Rank.Seven), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_NoAdjacentKings()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kb, o, kw, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            Move move1 = new Move(new Position(File.D, Rank.Six), new Position(File.E, Rank.Six), Player.Black);
            Move move2 = new Move(new Position(File.D, Rank.Six), new Position(File.E, Rank.Seven), Player.Black);
            Move move3 = new Move(new Position(File.D, Rank.Six), new Position(File.E, Rank.Five), Player.Black);

            Assert.False(cb.IsValidMove(move1), "move1 should be invalid");
            Assert.False(cb.IsValidMove(move2), "move2 should be invalid");
            Assert.False(cb.IsValidMove(move3), "move3 should be invalid");
        }

        [Test]
        public static void TestApplyMoveWhitePawn()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Assert.True(cb.ApplyMove(move1, false));
            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, pw, o, o, o },
                new[] { pw, pw, pw, pw, o, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            Assert.AreEqual(expected, cb.GetBoard(), "Unexpected board layout after applying move1");
            Move move2 = new Move(new Position(File.E, Rank.Three), new Position(File.E, Rank.Four), Player.White);
            Assert.True(cb.ApplyMove(move2, true));
            expected = new ChessPiece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, pw, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, pw, pw, pw, o, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            Assert.AreEqual(expected, cb.GetBoard(), "Unexpected board layout after applying move2");
        }

        [Test]
        public static void TestApplyMoveWhitePawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Four), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Six), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Four), new Position(File.E, Rank.Five), Player.White);
            Move move4 = new Move(new Position(File.D, Rank.Seven), new Position(File.D, Rank.Five), Player.Black);
            Move move5 = new Move(new Position(File.E, Rank.Five), new Position(File.D, Rank.Six), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, o, o, pb, pb, pb },
                new[] { o, o, o, pw, pb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, pw, pw, pw, o, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };

            Assert.AreEqual(board, cb.GetBoard(), "Unexpected board layout after en passant capture.");
        }

        [Test]
        public static void TestApplyMoveWhitePawn_PromotionToQueen()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Eight), Player.White, Piece.Queen);
            ChessGame cb = new ChessGame(board, Player.White);
            Assert.True(cb.ApplyMove(move, false), "move should be valid");

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { qw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackPawn_PromotionToQueen()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, pb, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(File.G, Rank.Two), new Position(File.G, Rank.One), Player.Black, Piece.Queen);
            ChessGame cb = new ChessGame(board, Player.Black);
            Assert.True(cb.ApplyMove(move, false), "move should be valid");

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, qb, o }
            };
            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestInvalidMoveWhitePawnPromotion_NoPieceSpecified()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(File.A, Rank.Seven), new Position(File.A, Rank.Eight), Player.White);
            ChessGame cb = new ChessGame(board, Player.White);
            Assert.False(cb.IsValidMove(move), "move should be invalid");
        }

        [Test]
        public static void TestInvalidMoveBlackPawnPromotion_NoPieceSpecified()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, kb, pb, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(File.G, Rank.Two), new Position(File.G, Rank.One), Player.Black);
            ChessGame cb = new ChessGame(board, Player.Black);
            Assert.False(cb.IsValidMove(move), "move should be invalid");
        }

        [Test]
        public static void TestApplyMoveBlackPawn_EnPassant()
        {
            ChessGame cb = new ChessGame();
            Move move1 = new Move(new Position(File.B, Rank.One), new Position(File.A, Rank.Three), Player.White);
            Move move2 = new Move(new Position(File.E, Rank.Seven), new Position(File.E, Rank.Five), Player.Black);
            Move move3 = new Move(new Position(File.E, Rank.Two), new Position(File.E, Rank.Three), Player.White);
            Move move4 = new Move(new Position(File.E, Rank.Five), new Position(File.E, Rank.Four), Player.Black);
            Move move5 = new Move(new Position(File.D, Rank.Two), new Position(File.D, Rank.Four), Player.White);
            Move move6 = new Move(new Position(File.E, Rank.Four), new Position(File.D, Rank.Three), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);

            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, o, pb, pb, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { nw, o, o, pb, pw, o, o, o },
                new[] { pw, pw, pw, o, o, pw, pw, pw },
                new[] { rw, o, bw, qw, kw, bw, nw, rw }
            };

            Assert.AreEqual(board, cb.GetBoard(), "Unexpected board layout after en passant capture.");
        }

        [Test]
        public static void TestApplyMoveWhiteKing_KingsideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, rw }
            };
            Move move = new Move(new Position(File.E, Rank.One), new Position(File.G, Rank.One), Player.White);
            ChessGame cb = new ChessGame(board, Player.White);
            cb.ApplyMove(move, true);

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, rw, kw, o }
            };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveWhiteKing_QueensideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { rw, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(File.E, Rank.One), new Position(File.C, Rank.One), Player.White);
            ChessGame cb = new ChessGame(board, Player.White);
            cb.ApplyMove(move, true);

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, kw, rw, o, o, o, o }
            };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackKing_KingsideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kb, o, o, rb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(File.E, Rank.Eight), new Position(File.G, Rank.Eight), Player.Black);
            ChessGame cb = new ChessGame(board, Player.Black);
            cb.ApplyMove(move, true);

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, rb, kb, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackKing_QueensideCastling()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { rb, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(File.E, Rank.Eight), new Position(File.C, Rank.Eight), Player.Black);
            ChessGame cb = new ChessGame(board, Player.Black);
            cb.ApplyMove(move, true);

            ChessPiece[][] expected = new ChessPiece[8][]
            {
                new[] { o, o, kb, rb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kw, o, o, o }
            };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestGetValidMovesWhiteStartingPosition()
        {
            ChessGame cb = new ChessGame();
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(Player.White);
            List<Move> expected = new List<Move>()
            {
                new Move("A2", "A3", Player.White),
                new Move("A2", "A4", Player.White),
                new Move("B2", "B3", Player.White),
                new Move("B2", "B4", Player.White),
                new Move("C2", "C3", Player.White),
                new Move("C2", "C4", Player.White),
                new Move("D2", "D3", Player.White),
                new Move("D2", "D4", Player.White),
                new Move("E2", "E3", Player.White),
                new Move("E2", "E4", Player.White),
                new Move("F2", "F3", Player.White),
                new Move("F2", "F4", Player.White),
                new Move("G2", "G3", Player.White),
                new Move("G2", "G4", Player.White),
                new Move("H2", "H3", Player.White),
                new Move("H2", "H4", Player.White),
                new Move("B1", "A3", Player.White),
                new Move("B1", "C3", Player.White),
                new Move("G1", "F3", Player.White),
                new Move("G1", "H3", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackStartingPosition()
        {
            ChessGame cb = new ChessGame();
            cb.ApplyMove(new Move(new Position(File.A, Rank.Two), new Position(File.A, Rank.Three), Player.White), true);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(Player.Black);
            List<Move> expected = new List<Move>()
            {
                new Move("A7", "A6", Player.Black),
                new Move("A7", "A5", Player.Black),
                new Move("B7", "B6", Player.Black),
                new Move("B7", "B5", Player.Black),
                new Move("C7", "C6", Player.Black),
                new Move("C7", "C5", Player.Black),
                new Move("D7", "D6", Player.Black),
                new Move("D7", "D5", Player.Black),
                new Move("E7", "E6", Player.Black),
                new Move("E7", "E5", Player.Black),
                new Move("F7", "F6", Player.Black),
                new Move("F7", "F5", Player.Black),
                new Move("G7", "G6", Player.Black),
                new Move("G7", "G5", Player.Black),
                new Move("H7", "H6", Player.Black),
                new Move("H7", "H5", Player.Black),
                new Move("B8", "A6", Player.Black),
                new Move("B8", "C6", Player.Black),
                new Move("G8", "F6", Player.Black),
                new Move("G8", "H6", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesWhiteKing()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, kb, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kw, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C3", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "C5", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "E3", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "E5", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesWhiteKnight()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, nw, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C2", Player.White),
                new Move("D4", "B3", Player.White),
                new Move("D4", "C6", Player.White),
                new Move("D4", "B5", Player.White),
                new Move("D4", "E2", Player.White),
                new Move("D4", "E6", Player.White),
                new Move("D4", "F3", Player.White),
                new Move("D4", "F5", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesWhiteBishop()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, bw, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "A1", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "H8", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "A1", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesWhiteRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kw, o, kb, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, rw, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Player.White),
                new Move("D4", "D2", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "D6", Player.White),
                new Move("D4", "D7", Player.White),
                new Move("D4", "D8", Player.White),
                new Move("D4", "A4", Player.White),
                new Move("D4", "B4", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "F4", Player.White),
                new Move("D4", "G4", Player.White),
                new Move("D4", "H4", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesWhiteQueen()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kw, o, kb, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, qw, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Player.White),
                new Move("D4", "D2", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "D6", Player.White),
                new Move("D4", "D7", Player.White),
                new Move("D4", "D8", Player.White),
                new Move("D4", "A4", Player.White),
                new Move("D4", "B4", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "F4", Player.White),
                new Move("D4", "G4", Player.White),
                new Move("D4", "H4", Player.White),
                new Move("D4", "A1", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "H8", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "A1", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackKing()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { kw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, kb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C3", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "C5", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "E3", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "E5", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackKnight()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, nb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C2", Player.Black),
                new Move("D4", "B3", Player.Black),
                new Move("D4", "C6", Player.Black),
                new Move("D4", "B5", Player.Black),
                new Move("D4", "E2", Player.Black),
                new Move("D4", "E6", Player.Black),
                new Move("D4", "F3", Player.Black),
                new Move("D4", "F5", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackBishop()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, kw, o, kb, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, bb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "A1", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "H8", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "A1", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackRook()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kw, o, kb, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, rb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Player.Black),
                new Move("D4", "D2", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "D6", Player.Black),
                new Move("D4", "D7", Player.Black),
                new Move("D4", "D8", Player.Black),
                new Move("D4", "A4", Player.Black),
                new Move("D4", "B4", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "F4", Player.Black),
                new Move("D4", "G4", Player.Black),
                new Move("D4", "H4", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestGetValidMovesBlackQueen()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, kw, o, kb, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, qb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(File.D, Rank.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Player.Black),
                new Move("D4", "D2", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "D6", Player.Black),
                new Move("D4", "D7", Player.Black),
                new Move("D4", "D8", Player.Black),
                new Move("D4", "A4", Player.Black),
                new Move("D4", "B4", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "F4", Player.Black),
                new Move("D4", "G4", Player.Black),
                new Move("D4", "H4", Player.Black),
                new Move("D4", "A1", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "H8", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "A1", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public static void TestIsWhiteInCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, o, o, o, o, o },
                new[] { kw, o, o, o, o, o, o, qb },
                new[] { pw, o, o, pb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { kb, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.Black, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("White is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsWhiteNotInCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { kw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, qb },
                new[] { pw, o, o, pb, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, kb, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestIsBlackInCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, nw, o, o, o, o },
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { kw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsBlackNotInCheck()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, o, nb, o, o, o, o },
                new[] { o, kb, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { kw, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestBlackCheckmated()
        {
            ChessGame cb = new ChessGame();
            cb.ApplyMove(new Move("E2", "E4", Player.White), true);
            cb.ApplyMove(new Move("E7", "E5", Player.Black), true);
            cb.ApplyMove(new Move("F1", "C4", Player.White), true);
            cb.ApplyMove(new Move("D7", "D6", Player.Black), true);
            cb.ApplyMove(new Move("D1", "F3", Player.White), true);
            cb.ApplyMove(new Move("H7", "H6", Player.Black), true);
            Assert.True(cb.ApplyMove(new Move("F3", "F7", Player.White), false));

            Assert.AreEqual(GameEvent.Checkmate, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is checkmated", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackStalemated()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { kb, o, kw, o, o, o, o, o },
                new[] { o, o, qw, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.Stalemate, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Stalemate", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackNotStalemated()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { kb, o, kw, o, o, o, o, o },
                new[] { o, o, qw, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, new List<Move>() { new Move("A7", "A8", Player.Black) });

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
            Assert.AreEqual(Player.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackNotStalematedAfterApplyMove()
        {
            ChessPiece[][] board  = new ChessPiece[8][]
            {
                new[] { o, o, kw, o, o, o, o, o },
                new[] { kb, o, qw, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o }
            };
            ChessGame cb = new ChessGame(board, Player.Black);

            Assert.True(cb.ApplyMove(new Move("A7", "A8", Player.Black), false));

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
            Assert.AreEqual(Player.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }
    }
}
