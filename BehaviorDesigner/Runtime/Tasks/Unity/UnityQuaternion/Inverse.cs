using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C6 RID: 5062
	[Token(Token = "0x2000D91")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150770", Offset = "0x150871")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150770", Offset = "0x150871")]
	public class Inverse : Action
	{
		// Token: 0x060075C8 RID: 30152 RVA: 0x00028D10 File Offset: 0x00026F10
		[Token(Token = "0x600627C")]
		[Address(RVA = "0x298ECF0", Offset = "0x298EDF1", VA = "0x298ECF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627D")]
		[Address(RVA = "0x298EDD0", Offset = "0x298EED1", VA = "0x298EDD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627E")]
		[Address(RVA = "0x298EE60", Offset = "0x298EF61", VA = "0x298EE60")]
		public Inverse()
		{
		}

		// Token: 0x0401B886 RID: 112774
		[Token(Token = "0x40182A7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AC70", Offset = "0x18AD71")]
		public SharedQuaternion targetQuaternion;

		// Token: 0x0401B887 RID: 112775
		[Token(Token = "0x40182A8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ACB0", Offset = "0x18ADB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18ACB0", Offset = "0x18ADB1")]
		public SharedQuaternion storeResult;
	}
}
