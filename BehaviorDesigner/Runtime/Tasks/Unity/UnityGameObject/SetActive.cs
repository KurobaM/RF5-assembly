using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001451 RID: 5201
	[Token(Token = "0x2000E17")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1539B0", Offset = "0x153AB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1539B0", Offset = "0x153AB1")]
	public class SetActive : Action
	{
		// Token: 0x06007797 RID: 30615 RVA: 0x000299A0 File Offset: 0x00027BA0
		[Token(Token = "0x600644B")]
		[Address(RVA = "0x28E5CD0", Offset = "0x28E5DD1", VA = "0x28E5CD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644C")]
		[Address(RVA = "0x28E5D70", Offset = "0x28E5E71", VA = "0x28E5D70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644D")]
		[Address(RVA = "0x28E5DC0", Offset = "0x28E5EC1", VA = "0x28E5DC0")]
		public SetActive()
		{
		}

		// Token: 0x0401BA59 RID: 113241
		[Token(Token = "0x4018457")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FC60", Offset = "0x18FD61")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA5A RID: 113242
		[Token(Token = "0x4018458")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FCA0", Offset = "0x18FDA1")]
		public SharedBool active;
	}
}
