using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001355 RID: 4949
	[Token(Token = "0x2000D20")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DCC0", Offset = "0x14DDC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DCC0", Offset = "0x14DDC1")]
	public class GetSubstring : Action
	{
		// Token: 0x06007430 RID: 29744 RVA: 0x00028278 File Offset: 0x00026478
		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x2999E80", Offset = "0x2999F81", VA = "0x2999E80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x2999F90", Offset = "0x299A091", VA = "0x2999F90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0x299A050", Offset = "0x299A151", VA = "0x299A050")]
		public GetSubstring()
		{
		}

		// Token: 0x0401B716 RID: 112406
		[Token(Token = "0x4018137")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186EC0", Offset = "0x186FC1")]
		public SharedString targetString;

		// Token: 0x0401B717 RID: 112407
		[Token(Token = "0x4018138")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186F00", Offset = "0x187001")]
		public SharedInt startIndex;

		// Token: 0x0401B718 RID: 112408
		[Token(Token = "0x4018139")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186F40", Offset = "0x187041")]
		public SharedInt length;

		// Token: 0x0401B719 RID: 112409
		[Token(Token = "0x401813A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186F80", Offset = "0x187081")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186F80", Offset = "0x187081")]
		public SharedString storeResult;
	}
}
