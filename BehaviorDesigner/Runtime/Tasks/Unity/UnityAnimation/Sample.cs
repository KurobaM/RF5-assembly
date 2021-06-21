using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014CA RID: 5322
	[Token(Token = "0x2000E8D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1565F0", Offset = "0x1566F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1565F0", Offset = "0x1566F1")]
	public class Sample : Action
	{
		// Token: 0x0600797E RID: 31102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006620")]
		[Address(RVA = "0x28D3B90", Offset = "0x28D3C91", VA = "0x28D3B90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x0002A510 File Offset: 0x00028710
		[Token(Token = "0x6006621")]
		[Address(RVA = "0x28D3C90", Offset = "0x28D3D91", VA = "0x28D3C90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006622")]
		[Address(RVA = "0x28D3D70", Offset = "0x28D3E71", VA = "0x28D3D70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006623")]
		[Address(RVA = "0x28D3D80", Offset = "0x28D3E81", VA = "0x28D3D80")]
		public Sample()
		{
		}

		// Token: 0x0401BC4D RID: 113741
		[Token(Token = "0x401863F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194220", Offset = "0x194321")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC4E RID: 113742
		[Token(Token = "0x4018640")]
		[FieldOffset(Offset = "0x58")]
		private Animation animation;

		// Token: 0x0401BC4F RID: 113743
		[Token(Token = "0x4018641")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
