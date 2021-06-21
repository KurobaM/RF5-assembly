using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200042E RID: 1070
[Token(Token = "0x200033A")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145C80", Offset = "0x145D81")]
[Serializable]
public class EventData
{
	// Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001707")]
	[Address(RVA = "0x21E8B80", Offset = "0x21E8C81", VA = "0x21E8B80")]
	public void InitParam(bool _orderInit = true)
	{
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001708")]
	[Address(RVA = "0x21E8C00", Offset = "0x21E8D01", VA = "0x21E8C00")]
	public void InitOrderParam()
	{
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001709")]
	[Address(RVA = "0x21E8C10", Offset = "0x21E8D11", VA = "0x21E8C10")]
	public void SetCurrentStep(int currentStep)
	{
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x21E8C20", Offset = "0x21E8D21", VA = "0x21E8C20")]
	public void SetCurrentReservedStep(int currentReservedStep)
	{
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x21E8C30", Offset = "0x21E8D31", VA = "0x21E8C30")]
	public void SetNextStep(int nextStep)
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x21E8C40", Offset = "0x21E8D41", VA = "0x21E8C40")]
	public void SetNpcEventType(NpcEventType type)
	{
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x21E8C50", Offset = "0x21E8D51", VA = "0x21E8C50")]
	public void SetNpcEventPath(string path)
	{
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x0000B2F8 File Offset: 0x000094F8
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x21E8D40", Offset = "0x21E8E41", VA = "0x21E8D40")]
	public int GetCurrentStep()
	{
		return 0;
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x0000B310 File Offset: 0x00009510
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x21E8D50", Offset = "0x21E8E51", VA = "0x21E8D50")]
	public int GetCurrentReservedStep()
	{
		return 0;
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x0000B328 File Offset: 0x00009528
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x21E8D60", Offset = "0x21E8E61", VA = "0x21E8D60")]
	public int GetNextStep()
	{
		return 0;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x0000B340 File Offset: 0x00009540
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x21E8D70", Offset = "0x21E8E71", VA = "0x21E8D70")]
	public NpcEventType GetNpcEventType()
	{
		return NpcEventType.None;
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x21E8D80", Offset = "0x21E8E81", VA = "0x21E8D80")]
	public string GetNpcEventPath()
	{
		return null;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x21E8D90", Offset = "0x21E8E91", VA = "0x21E8D90")]
	public void AddCurrentReservedStep()
	{
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x21E8DA0", Offset = "0x21E8EA1", VA = "0x21E8DA0")]
	public EventData()
	{
	}

	// Token: 0x04005CFF RID: 23807
	[Token(Token = "0x4005946")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163780", Offset = "0x163881")]
	[SerializeField]
	public int EventId;

	// Token: 0x04005D00 RID: 23808
	[Token(Token = "0x4005947")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1637D0", Offset = "0x1638D1")]
	[SerializeField]
	public int EventState;

	// Token: 0x04005D01 RID: 23809
	[Token(Token = "0x4005948")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163820", Offset = "0x163921")]
	[SerializeField]
	public int OrderId;

	// Token: 0x04005D02 RID: 23810
	[Token(Token = "0x4005949")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163870", Offset = "0x163971")]
	[SerializeField]
	public int CurrentStep;

	// Token: 0x04005D03 RID: 23811
	[Token(Token = "0x400594A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1638C0", Offset = "0x1639C1")]
	[SerializeField]
	public int CurrentReservedStep;

	// Token: 0x04005D04 RID: 23812
	[Token(Token = "0x400594B")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163910", Offset = "0x163A11")]
	[SerializeField]
	public int NextStep;

	// Token: 0x04005D05 RID: 23813
	[Token(Token = "0x400594C")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163960", Offset = "0x163A61")]
	[SerializeField]
	public NpcEventType CurrentNpcEventType;

	// Token: 0x04005D06 RID: 23814
	[Token(Token = "0x400594D")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1639B0", Offset = "0x163AB1")]
	[SerializeField]
	public string CurrentNpcEventPath;

	// Token: 0x04005D07 RID: 23815
	[Token(Token = "0x400594E")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163A00", Offset = "0x163B01")]
	[SerializeField]
	public int CurrentTargetEventStep;

	// Token: 0x04005D08 RID: 23816
	[Token(Token = "0x400594F")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163A50", Offset = "0x163B51")]
	[SerializeField]
	public List<SubEventStep> SubEventSteps;
}
