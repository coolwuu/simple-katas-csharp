using System;
using NUnit.Framework;

namespace RnaTranscription
{
    [TestFixture]
    public class RnaTest
    {
        [Test]
        public void RnaTranscriptionOfEmptyDnaIsEmptyRna()
        {
            Assert.AreEqual("", Rna.Transcribe(""));
        }

        
        [Test]
        public void RnaTranscriptionOfCytosineIsGuanine()
        {
            Assert.AreEqual("G", Rna.Transcribe("C"));
        }

        
        [Test]
        public void RnaTranscriptionOfGuanineIsCytosine()
        {
            Assert.AreEqual("C", Rna.Transcribe("G"));
        }

        
        [Test]
        public void RnaTranscriptionOfThymineIsAdenine()
        {
            Assert.AreEqual("A", Rna.Transcribe("T"));
        }

        [Test]
        public void RnaTranscriptionOfAdenineIsUracil()
        {
            Assert.AreEqual("U", Rna.Transcribe("A"));
        }

        [Test]
        public void X()
        {
            Assert.AreEqual("UU", Rna.Transcribe("AA"));
        }

        
        [Test]
        public void RnaTranscription()
        {
            Assert.AreEqual("UGCACCAGAAUU", Rna.Transcribe("ACGTGGTCTTAA"));
        }

      
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfRnaThrowsAnError()
        {
            Rna.Transcribe("U");
        }

        
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfInvalidInputThrowsAnError()
        {
            Rna.Transcribe("BFV");
        }

        [Ignore("Remove to run test")]
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfPartiallyInvalidInput()
        {
            Rna.Transcribe("GCVV");
        }

    }
}
