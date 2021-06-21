using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001307 RID: 4871
	[Token(Token = "0x2000CD4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C040", Offset = "0x14C141")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C040", Offset = "0x14C141")]
	public class GetRightVector : Action
	{
		// Token: 0x06007326 RID: 29478 RVA: 0x00027B58 File Offset: 0x00025D58
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0x2449DE0", Offset = "0x2449EE1", VA = "0x2449DE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0x2449E70", Offset = "0x2449F71", VA = "0x2449E70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0x2449EF0", Offset = "0x2449FF1", VA = "0x2449EF0")]
		public GetRightVector()
		{
		}

		// Token: 0x0401B60E RID: 112142
		[Token(Token = "0x4018037")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183F20", Offset = "0x184021")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183F20", Offset = "0x184021")]
		public SharedVector3 storeResult;
	}
}
