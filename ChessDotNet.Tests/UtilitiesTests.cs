﻿using System;
using NUnit.Framework;

namespace ChessDotNet.Tests
{
    [TestFixture]
    public static class UtilitiesTests
    {
        [Test]
        public static void TestThrowIfNull()
        {
            Assert.Throws<ArgumentNullException>(delegate ()
            {
                object value = null;
                Utilities.ThrowIfNull(value, "value");
            });

            Assert.DoesNotThrow(delegate ()
            {
                ChessPiece piece = new ChessPiece(Piece.Bishop, Player.White);
                Utilities.ThrowIfNull(piece, "piece");
            });
        }

        [Test]
        public static void TestGetOpponentOf()
        {
            Assert.AreEqual(Player.Black, Utilities.GetOpponentOf(Player.White));
            Assert.AreEqual(Player.White, Utilities.GetOpponentOf(Player.Black));
            Assert.Throws<ArgumentException>(delegate ()
            {
                Utilities.GetOpponentOf(Player.None);
            });
        }
    }
}
