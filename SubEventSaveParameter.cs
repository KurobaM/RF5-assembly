using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AC RID: 1196
[Token(Token = "0x2000378")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145E60", Offset = "0x145F61")]
[Serializable]
public class SubEventSaveParameter
{
	// Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193E")]
	[Address(RVA = "0x1FAB410", Offset = "0x1FAB511", VA = "0x1FAB410")]
	public void Initialize()
	{
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600193F")]
	[Address(RVA = "0x1FAB420", Offset = "0x1FAB521", VA = "0x1FAB420")]
	public void SetParameter(SubEventSaveParameter param)
	{
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001940")]
	[Address(RVA = "0x1FAB470", Offset = "0x1FAB571", VA = "0x1FAB470")]
	public SubEventSaveParameter()
	{
	}

	// Token: 0x040062C7 RID: 25287
	[Token(Token = "0x4005DB0")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164A50", Offset = "0x164B51")]
	[SerializeField]
	public int Step;

	// Token: 0x040062C8 RID: 25288
	[Token(Token = "0x4005DB1")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164AA0", Offset = "0x164BA1")]
	[SerializeField]
	public int NextStep;

	// Token: 0x040062C9 RID: 25289
	[Token(Token = "0x4005DB2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164AF0", Offset = "0x164BF1")]
	[SerializeField]
	public int NextStepDaysLeft;

	// Token: 0x040062CA RID: 25290
	[Token(Token = "0x4005DB3")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164B40", Offset = "0x164C41")]
	[SerializeField]
	public int NextStepTime;

	// Token: 0x040062CB RID: 25291
	[Token(Token = "0x4005DB4")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164B90", Offset = "0x164C91")]
	[SerializeField]
	public bool NextStepConfig;

	// Token: 0x040062CC RID: 25292
	[Token(Token = "0x4005DB5")]
	[FieldOffset(Offset = "0x21")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164BE0", Offset = "0x164CE1")]
	[SerializeField]
	public bool Completed;

	// Token: 0x040062CD RID: 25293
	[Token(Token = "0x4005DB6")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164C30", Offset = "0x164D31")]
	[SerializeField]
	public int CompletedDate;
}
