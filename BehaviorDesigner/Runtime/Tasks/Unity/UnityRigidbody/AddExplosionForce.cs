using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139A RID: 5018
	[Token(Token = "0x2000D65")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F6A0", Offset = "0x14F7A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F6A0", Offset = "0x14F7A1")]
	public class AddExplosionForce : Action
	{
		// Token: 0x0600751E RID: 29982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D2")]
		[Address(RVA = "0x298FAC0", Offset = "0x298FBC1", VA = "0x298FAC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x000288F0 File Offset: 0x00026AF0
		[Token(Token = "0x60061D3")]
		[Address(RVA = "0x298FBC0", Offset = "0x298FCC1", VA = "0x298FBC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D4")]
		[Address(RVA = "0x298FD20", Offset = "0x298FE21", VA = "0x298FD20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D5")]
		[Address(RVA = "0x298FDF0", Offset = "0x298FEF1", VA = "0x298FDF0")]
		public AddExplosionForce()
		{
		}

		// Token: 0x0401B7DB RID: 112603
		[Token(Token = "0x40181FC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1893A0", Offset = "0x1894A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7DC RID: 112604
		[Token(Token = "0x40181FD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1893E0", Offset = "0x1894E1")]
		public SharedFloat explosionForce;

		// Token: 0x0401B7DD RID: 112605
		[Token(Token = "0x40181FE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189420", Offset = "0x189521")]
		public SharedVector3 explosionPosition;

		// Token: 0x0401B7DE RID: 112606
		[Token(Token = "0x40181FF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189460", Offset = "0x189561")]
		public SharedFloat explosionRadius;

		// Token: 0x0401B7DF RID: 112607
		[Token(Token = "0x4018200")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1894A0", Offset = "0x1895A1")]
		public float upwardsModifier;

		// Token: 0x0401B7E0 RID: 112608
		[Token(Token = "0x4018201")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1894E0", Offset = "0x1895E1")]
		public ForceMode forceMode;

		// Token: 0x0401B7E1 RID: 112609
		[Token(Token = "0x4018202")]
		[FieldOffset(Offset = "0x78")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7E2 RID: 112610
		[Token(Token = "0x4018203")]
		[FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;
	}
}
