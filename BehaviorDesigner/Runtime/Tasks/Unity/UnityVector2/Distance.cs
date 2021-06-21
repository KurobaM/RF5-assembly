using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001316 RID: 4886
	[Token(Token = "0x2000CE2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C580", Offset = "0x14C681")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C580", Offset = "0x14C681")]
	public class Distance : Action
	{
		// Token: 0x06007350 RID: 29520 RVA: 0x00027CA8 File Offset: 0x00025EA8
		[Token(Token = "0x6006004")]
		[Address(RVA = "0x299FC40", Offset = "0x299FD41", VA = "0x299FC40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006005")]
		[Address(RVA = "0x299FD30", Offset = "0x299FE31", VA = "0x299FD30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006006")]
		[Address(RVA = "0x299FDF0", Offset = "0x299FEF1", VA = "0x299FDF0")]
		public Distance()
		{
		}

		// Token: 0x0401B63B RID: 112187
		[Token(Token = "0x4018060")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184A30", Offset = "0x184B31")]
		public SharedVector2 firstVector2;

		// Token: 0x0401B63C RID: 112188
		[Token(Token = "0x4018061")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184A70", Offset = "0x184B71")]
		public SharedVector2 secondVector2;

		// Token: 0x0401B63D RID: 112189
		[Token(Token = "0x4018062")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184AB0", Offset = "0x184BB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184AB0", Offset = "0x184BB1")]
		public SharedFloat storeResult;
	}
}
