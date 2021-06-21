using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137C RID: 4988
	[Token(Token = "0x2000D47")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EB60", Offset = "0x14EC61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EB60", Offset = "0x14EC61")]
	public class SetSharedVector4 : Action
	{
		// Token: 0x060074A9 RID: 29865 RVA: 0x00028620 File Offset: 0x00026820
		[Token(Token = "0x600615D")]
		[Address(RVA = "0x28D0EB0", Offset = "0x28D0FB1", VA = "0x28D0EB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615E")]
		[Address(RVA = "0x28D0F30", Offset = "0x28D1031", VA = "0x28D0F30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615F")]
		[Address(RVA = "0x28D0FD0", Offset = "0x28D10D1", VA = "0x28D0FD0")]
		public SetSharedVector4()
		{
		}

		// Token: 0x0401B770 RID: 112496
		[Token(Token = "0x4018191")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188480", Offset = "0x188581")]
		public SharedVector4 targetValue;

		// Token: 0x0401B771 RID: 112497
		[Token(Token = "0x4018192")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1884C0", Offset = "0x1885C1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1884C0", Offset = "0x1885C1")]
		public SharedVector4 targetVariable;
	}
}
