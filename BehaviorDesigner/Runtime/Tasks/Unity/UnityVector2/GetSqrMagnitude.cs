using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131A RID: 4890
	[Token(Token = "0x2000CE6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C700", Offset = "0x14C801")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C700", Offset = "0x14C801")]
	public class GetSqrMagnitude : Action
	{
		// Token: 0x0600735C RID: 29532 RVA: 0x00027D08 File Offset: 0x00025F08
		[Token(Token = "0x6006010")]
		[Address(RVA = "0x29A0230", Offset = "0x29A0331", VA = "0x29A0230", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006011")]
		[Address(RVA = "0x29A02D0", Offset = "0x29A03D1", VA = "0x29A02D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006012")]
		[Address(RVA = "0x29A0370", Offset = "0x29A0471", VA = "0x29A0370")]
		public GetSqrMagnitude()
		{
		}

		// Token: 0x0401B644 RID: 112196
		[Token(Token = "0x4018069")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184CB0", Offset = "0x184DB1")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B645 RID: 112197
		[Token(Token = "0x401806A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184CF0", Offset = "0x184DF1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184CF0", Offset = "0x184DF1")]
		public SharedFloat storeResult;
	}
}
