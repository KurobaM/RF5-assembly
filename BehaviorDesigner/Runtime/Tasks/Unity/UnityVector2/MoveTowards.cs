using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131F RID: 4895
	[Token(Token = "0x2000CEB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C8E0", Offset = "0x14C9E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C8E0", Offset = "0x14C9E1")]
	public class MoveTowards : Action
	{
		// Token: 0x0600736B RID: 29547 RVA: 0x00027D80 File Offset: 0x00025F80
		[Token(Token = "0x600601F")]
		[Address(RVA = "0x29A09B0", Offset = "0x29A0AB1", VA = "0x29A09B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006020")]
		[Address(RVA = "0x29A0AD0", Offset = "0x29A0BD1", VA = "0x29A0AD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006021")]
		[Address(RVA = "0x29A0BB0", Offset = "0x29A0CB1", VA = "0x29A0BB0")]
		public MoveTowards()
		{
		}

		// Token: 0x0401B650 RID: 112208
		[Token(Token = "0x4018075")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185010", Offset = "0x185111")]
		public SharedVector2 currentPosition;

		// Token: 0x0401B651 RID: 112209
		[Token(Token = "0x4018076")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185050", Offset = "0x185151")]
		public SharedVector2 targetPosition;

		// Token: 0x0401B652 RID: 112210
		[Token(Token = "0x4018077")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185090", Offset = "0x185191")]
		public SharedFloat speed;

		// Token: 0x0401B653 RID: 112211
		[Token(Token = "0x4018078")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1850D0", Offset = "0x1851D1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1850D0", Offset = "0x1851D1")]
		public SharedVector2 storeResult;
	}
}
