using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001354 RID: 4948
	[Token(Token = "0x2000D1F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DC60", Offset = "0x14DD61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DC60", Offset = "0x14DD61")]
	public class GetRandomString : Action
	{
		// Token: 0x0600742D RID: 29741 RVA: 0x00028260 File Offset: 0x00026460
		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x2999D70", Offset = "0x2999E71", VA = "0x2999D70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x2999E30", Offset = "0x2999F31", VA = "0x2999E30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x2999E70", Offset = "0x2999F71", VA = "0x2999E70")]
		public GetRandomString()
		{
		}

		// Token: 0x0401B714 RID: 112404
		[Token(Token = "0x4018135")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186E30", Offset = "0x186F31")]
		public SharedString[] source;

		// Token: 0x0401B715 RID: 112405
		[Token(Token = "0x4018136")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186E70", Offset = "0x186F71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186E70", Offset = "0x186F71")]
		public SharedString storeResult;
	}
}
