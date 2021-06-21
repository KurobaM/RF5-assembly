using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014CD RID: 5325
	[Token(Token = "0x2000E90")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156710", Offset = "0x156811")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156710", Offset = "0x156811")]
	public class Stop : Action
	{
		// Token: 0x0600798A RID: 31114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662C")]
		[Address(RVA = "0x28D4230", Offset = "0x28D4331", VA = "0x28D4230", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x0002A558 File Offset: 0x00028758
		[Token(Token = "0x600662D")]
		[Address(RVA = "0x28D4330", Offset = "0x28D4431", VA = "0x28D4330", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662E")]
		[Address(RVA = "0x28D4460", Offset = "0x28D4561", VA = "0x28D4460", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662F")]
		[Address(RVA = "0x28D44D0", Offset = "0x28D45D1", VA = "0x28D44D0")]
		public Stop()
		{
		}

		// Token: 0x0401BC58 RID: 113752
		[Token(Token = "0x401864A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194360", Offset = "0x194461")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC59 RID: 113753
		[Token(Token = "0x401864B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1943A0", Offset = "0x1944A1")]
		public SharedString animationName;

		// Token: 0x0401BC5A RID: 113754
		[Token(Token = "0x401864C")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC5B RID: 113755
		[Token(Token = "0x401864D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
