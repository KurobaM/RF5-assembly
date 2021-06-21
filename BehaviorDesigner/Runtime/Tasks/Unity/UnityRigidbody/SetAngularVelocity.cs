using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B0 RID: 5040
	[Token(Token = "0x2000D7B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FF30", Offset = "0x150031")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FF30", Offset = "0x150031")]
	public class SetAngularVelocity : Action
	{
		// Token: 0x06007576 RID: 30070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622A")]
		[Address(RVA = "0x29931A0", Offset = "0x29932A1", VA = "0x29931A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00028B00 File Offset: 0x00026D00
		[Token(Token = "0x600622B")]
		[Address(RVA = "0x29932A0", Offset = "0x29933A1", VA = "0x29932A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622C")]
		[Address(RVA = "0x2993390", Offset = "0x2993491", VA = "0x2993390", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622D")]
		[Address(RVA = "0x2993420", Offset = "0x2993521", VA = "0x2993420")]
		public SetAngularVelocity()
		{
		}

		// Token: 0x0401B83B RID: 112699
		[Token(Token = "0x401825C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A150", Offset = "0x18A251")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B83C RID: 112700
		[Token(Token = "0x401825D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A190", Offset = "0x18A291")]
		public SharedVector3 angularVelocity;

		// Token: 0x0401B83D RID: 112701
		[Token(Token = "0x401825E")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B83E RID: 112702
		[Token(Token = "0x401825F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
