using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001304 RID: 4868
	[Token(Token = "0x2000CD1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BF20", Offset = "0x14C021")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BF20", Offset = "0x14C021")]
	public class Dot : Action
	{
		// Token: 0x0600731D RID: 29469 RVA: 0x00027B10 File Offset: 0x00025D10
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x2449990", Offset = "0x2449A91", VA = "0x2449990", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x2449AA0", Offset = "0x2449BA1", VA = "0x2449AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x2449B60", Offset = "0x2449C61", VA = "0x2449B60")]
		public Dot()
		{
		}

		// Token: 0x0401B608 RID: 112136
		[Token(Token = "0x4018031")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183D70", Offset = "0x183E71")]
		public SharedVector3 leftHandSide;

		// Token: 0x0401B609 RID: 112137
		[Token(Token = "0x4018032")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183DB0", Offset = "0x183EB1")]
		public SharedVector3 rightHandSide;

		// Token: 0x0401B60A RID: 112138
		[Token(Token = "0x4018033")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183DF0", Offset = "0x183EF1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183DF0", Offset = "0x183EF1")]
		public SharedFloat storeResult;
	}
}
