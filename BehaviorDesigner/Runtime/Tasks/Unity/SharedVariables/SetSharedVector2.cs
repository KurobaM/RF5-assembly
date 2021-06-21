using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137A RID: 4986
	[Token(Token = "0x2000D45")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EAA0", Offset = "0x14EBA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EAA0", Offset = "0x14EBA1")]
	public class SetSharedVector2 : Action
	{
		// Token: 0x060074A3 RID: 29859 RVA: 0x000285F0 File Offset: 0x000267F0
		[Token(Token = "0x6006157")]
		[Address(RVA = "0x28D0C50", Offset = "0x28D0D51", VA = "0x28D0C50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006158")]
		[Address(RVA = "0x28D0CD0", Offset = "0x28D0DD1", VA = "0x28D0CD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006159")]
		[Address(RVA = "0x28D0D70", Offset = "0x28D0E71", VA = "0x28D0D70")]
		public SetSharedVector2()
		{
		}

		// Token: 0x0401B76C RID: 112492
		[Token(Token = "0x401818D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188360", Offset = "0x188461")]
		public SharedVector2 targetValue;

		// Token: 0x0401B76D RID: 112493
		[Token(Token = "0x401818E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1883A0", Offset = "0x1884A1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1883A0", Offset = "0x1884A1")]
		public SharedVector2 targetVariable;
	}
}
