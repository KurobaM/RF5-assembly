using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C3 RID: 5059
	[Token(Token = "0x2000D8E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150650", Offset = "0x150751")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150650", Offset = "0x150751")]
	public class Euler : Action
	{
		// Token: 0x060075BF RID: 30143 RVA: 0x00028CC8 File Offset: 0x00026EC8
		[Token(Token = "0x6006273")]
		[Address(RVA = "0x298E840", Offset = "0x298E941", VA = "0x298E840", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006274")]
		[Address(RVA = "0x298E910", Offset = "0x298EA11", VA = "0x298E910", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006275")]
		[Address(RVA = "0x298E9D0", Offset = "0x298EAD1", VA = "0x298E9D0")]
		public Euler()
		{
		}

		// Token: 0x0401B880 RID: 112768
		[Token(Token = "0x40182A1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AAC0", Offset = "0x18ABC1")]
		public SharedVector3 eulerVector;

		// Token: 0x0401B881 RID: 112769
		[Token(Token = "0x40182A2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AB00", Offset = "0x18AC01")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18AB00", Offset = "0x18AC01")]
		public SharedQuaternion storeResult;
	}
}
