using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001312 RID: 4882
	[Token(Token = "0x2000CDE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C400", Offset = "0x14C501")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C400", Offset = "0x14C501")]
	public class RotateTowards : Action
	{
		// Token: 0x06007344 RID: 29508 RVA: 0x00027C48 File Offset: 0x00025E48
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x244AF60", Offset = "0x244B061", VA = "0x244AF60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x244B0C0", Offset = "0x244B1C1", VA = "0x244B0C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x244B1C0", Offset = "0x244B2C1", VA = "0x244B1C0")]
		public RotateTowards()
		{
		}

		// Token: 0x0401B62D RID: 112173
		[Token(Token = "0x4018052")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184690", Offset = "0x184791")]
		public SharedVector3 currentRotation;

		// Token: 0x0401B62E RID: 112174
		[Token(Token = "0x4018053")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1846D0", Offset = "0x1847D1")]
		public SharedVector3 targetRotation;

		// Token: 0x0401B62F RID: 112175
		[Token(Token = "0x4018054")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184710", Offset = "0x184811")]
		public SharedFloat maxDegreesDelta;

		// Token: 0x0401B630 RID: 112176
		[Token(Token = "0x4018055")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184750", Offset = "0x184851")]
		public SharedFloat maxMagnitudeDelta;

		// Token: 0x0401B631 RID: 112177
		[Token(Token = "0x4018056")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184790", Offset = "0x184891")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184790", Offset = "0x184891")]
		public SharedVector3 storeResult;
	}
}
