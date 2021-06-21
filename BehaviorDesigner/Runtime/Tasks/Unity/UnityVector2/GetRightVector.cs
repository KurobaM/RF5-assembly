using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001319 RID: 4889
	[Token(Token = "0x2000CE5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C6A0", Offset = "0x14C7A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C6A0", Offset = "0x14C7A1")]
	public class GetRightVector : Action
	{
		// Token: 0x06007359 RID: 29529 RVA: 0x00027CF0 File Offset: 0x00025EF0
		[Token(Token = "0x600600D")]
		[Address(RVA = "0x29A0110", Offset = "0x29A0211", VA = "0x29A0110", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600E")]
		[Address(RVA = "0x29A01A0", Offset = "0x29A02A1", VA = "0x29A01A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600F")]
		[Address(RVA = "0x29A0220", Offset = "0x29A0321", VA = "0x29A0220")]
		public GetRightVector()
		{
		}

		// Token: 0x0401B643 RID: 112195
		[Token(Token = "0x4018068")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184C60", Offset = "0x184D61")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184C60", Offset = "0x184D61")]
		public SharedVector2 storeResult;
	}
}
