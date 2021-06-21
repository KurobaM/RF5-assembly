using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014CF RID: 5327
	[Token(Token = "0x2000E92")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1567D0", Offset = "0x1568D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1567D0", Offset = "0x1568D1")]
	public class ExistSharedGameObject : Conditional
	{
		// Token: 0x06007992 RID: 31122 RVA: 0x0002A588 File Offset: 0x00028788
		[Token(Token = "0x6006634")]
		[Address(RVA = "0x220EDA0", Offset = "0x220EEA1", VA = "0x220EDA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006635")]
		[Address(RVA = "0x220EE40", Offset = "0x220EF41", VA = "0x220EE40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006636")]
		[Address(RVA = "0x220EE50", Offset = "0x220EF51", VA = "0x220EE50")]
		public ExistSharedGameObject()
		{
		}

		// Token: 0x0401BC5F RID: 113759
		[Token(Token = "0x4018651")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194420", Offset = "0x194521")]
		public SharedGameObject variable;
	}
}
