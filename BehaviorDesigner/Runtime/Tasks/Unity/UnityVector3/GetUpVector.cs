using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001309 RID: 4873
	[Token(Token = "0x2000CD6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C100", Offset = "0x14C201")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C100", Offset = "0x14C201")]
	public class GetUpVector : Action
	{
		// Token: 0x0600732C RID: 29484 RVA: 0x00027B88 File Offset: 0x00025D88
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0x244A050", Offset = "0x244A151", VA = "0x244A050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0x244A0E0", Offset = "0x244A1E1", VA = "0x244A0E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0x244A160", Offset = "0x244A261", VA = "0x244A160")]
		public GetUpVector()
		{
		}

		// Token: 0x0401B611 RID: 112145
		[Token(Token = "0x401803A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184000", Offset = "0x184101")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184000", Offset = "0x184101")]
		public SharedVector3 storeResult;
	}
}
