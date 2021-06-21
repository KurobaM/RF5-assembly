using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A5 RID: 5029
	[Token(Token = "0x2000D70")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FB10", Offset = "0x14FC11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FB10", Offset = "0x14FC11")]
	public class GetIsKinematic : Action
	{
		// Token: 0x0600754A RID: 30026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0x2991770", Offset = "0x2991871", VA = "0x2991770", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x000289F8 File Offset: 0x00026BF8
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0x2991870", Offset = "0x2991971", VA = "0x2991870", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006200")]
		[Address(RVA = "0x2991970", Offset = "0x2991A71", VA = "0x2991970", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006201")]
		[Address(RVA = "0x29919C0", Offset = "0x2991AC1", VA = "0x29919C0")]
		public GetIsKinematic()
		{
		}

		// Token: 0x0401B811 RID: 112657
		[Token(Token = "0x4018232")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189BF0", Offset = "0x189CF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B812 RID: 112658
		[Token(Token = "0x4018233")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189C30", Offset = "0x189D31")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189C30", Offset = "0x189D31")]
		public SharedBool storeValue;

		// Token: 0x0401B813 RID: 112659
		[Token(Token = "0x4018234")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B814 RID: 112660
		[Token(Token = "0x4018235")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
