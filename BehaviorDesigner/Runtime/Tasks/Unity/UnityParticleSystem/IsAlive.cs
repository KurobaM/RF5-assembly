using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E4 RID: 5092
	[Token(Token = "0x2000DAF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1512B0", Offset = "0x1513B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1512B0", Offset = "0x1513B1")]
	public class IsAlive : Conditional
	{
		// Token: 0x06007629 RID: 30249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DD")]
		[Address(RVA = "0x2989410", Offset = "0x2989511", VA = "0x2989410", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00028FE0 File Offset: 0x000271E0
		[Token(Token = "0x60062DE")]
		[Address(RVA = "0x2989510", Offset = "0x2989611", VA = "0x2989510", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0x29895F0", Offset = "0x29896F1", VA = "0x29895F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E0")]
		[Address(RVA = "0x2989600", Offset = "0x2989701", VA = "0x2989600")]
		public IsAlive()
		{
		}

		// Token: 0x0401B8FB RID: 112891
		[Token(Token = "0x401831C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C730", Offset = "0x18C831")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8FC RID: 112892
		[Token(Token = "0x401831D")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8FD RID: 112893
		[Token(Token = "0x401831E")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
