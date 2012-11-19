// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using NUnit.Framework;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace PexBinaryHeap.Tests.Pex
{
    public partial class BinaryHeapTests
    {
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedException(typeof(AssertionException))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsAssertionException873()
{
    int[] ints = new int[2];
    ints[0] = 1023;
    ints[1] = 1023;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue674()
{
    int[] ints = new int[3];
    ints[0] = 1;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[Ignore("the test state was: path bounds exceeded")]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue765()
{
    int[] ints = new int[11];
    ints[0] = 521;
    ints[1] = 515;
    ints[2] = 513;
    ints[3] = 64;
    ints[4] = 64;
    ints[5] = 64;
    ints[6] = 64;
    ints[7] = 64;
    ints[8] = 64;
    ints[9] = 64;
    ints[10] = 64;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedContractException]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsContractException926()
{
    int[] ints = new int[2];
    ints[0] = 3;
    ints[1] = 2;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue811()
{
    int[] ints = new int[3];
    ints[0] = 1023;
    ints[1] = 1023;
    ints[2] = 1023;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedContractException]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsContractException221()
{
    int[] ints = new int[5];
    ints[0] = 3;
    ints[1] = 2;
    ints[2] = 1;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedContractException]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsContractException908()
{
    int[] ints = new int[3];
    ints[1] = 512;
    ints[2] = 1;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsContractException831()
{
    try
    {
      int[] ints = new int[1];
      this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
      throw 
        new AssertionException("expected an exception of type ContractException");
    }
    catch(Exception ex)
    {
      if (!PexContract.IsContractException(ex))
        throw ex;
    }
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue81601()
{
    int[] ints = new int[2];
    ints[0] = 1;
    ints[1] = 512;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
[PexRaisedContractException]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValueThrowsContractException770()
{
    int[] ints = new int[4];
    ints[0] = 873;
    ints[1] = 256;
    ints[2] = 24;
    ints[3] = 484;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue312()
{
    int[] ints = new int[16];
    ints[0] = 1023;
    ints[1] = 1022;
    ints[2] = 1021;
    ints[3] = 1020;
    ints[4] = 1020;
    ints[5] = 1020;
    ints[6] = 1020;
    ints[7] = -2147482872;
    ints[8] = 520;
    ints[9] = 544;
    ints[10] = 616;
    ints[11] = 552;
    ints[12] = 544;
    ints[13] = 768;
    ints[14] = 520;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue971()
{
    int[] ints = new int[16];
    ints[0] = 531;
    ints[1] = 520;
    ints[2] = 516;
    ints[3] = 272;
    ints[4] = 272;
    ints[5] = 272;
    ints[6] = 272;
    ints[7] = -2147483637;
    ints[8] = 17;
    ints[9] = 256;
    ints[10] = 257;
    ints[11] = 272;
    ints[12] = 265;
    ints[13] = 267;
    ints[14] = 12;
    ints[15] = 16;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue816()
{
    int[] ints = new int[1];
    ints[0] = 1;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue959()
{
    int[] ints = new int[11];
    ints[0] = 5;
    ints[1] = 4;
    ints[2] = 3;
    ints[3] = 2;
    ints[4] = 8;
    ints[5] = 2;
    ints[6] = 4;
    ints[7] = 2;
    ints[8] = 2;
    ints[9] = 2;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
[Test]
[PexGeneratedBy(typeof(BinaryHeapTests))]
public void Extract_WhenHeapContainsSeveralElements_ResultIsMinValue521()
{
    int[] ints = new int[11];
    ints[0] = 289;
    ints[1] = 16;
    ints[2] = 1;
    ints[4] = 256;
    ints[5] = 1;
    ints[6] = 1;
    ints[7] = 3;
    ints[8] = 800;
    ints[9] = 260;
    ints[10] = 258;
    this.Extract_WhenHeapContainsSeveralElements_ResultIsMinValue(ints);
}
    }
}
