using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E3 RID: 5091
	[Token(Token = "0x2000DAE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151250", Offset = "0x151351")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151250", Offset = "0x151351")]
	public class GetTime : Action
	{
		// Token: 0x06007625 RID: 30245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D9")]
		[Address(RVA = "0x29891C0", Offset = "0x29892C1", VA = "0x29891C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00028FC8 File Offset: 0x000271C8
		[Token(Token = "0x60062DA")]
		[Address(RVA = "0x29892C0", Offset = "0x29893C1", VA = "0x29892C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DB")]
		[Address(RVA = "0x29893B0", Offset = "0x29894B1", VA = "0x29893B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DC")]
		[Address(RVA = "0x2989400", Offset = "0x2989501", VA = "0x2989400")]
		public GetTime()
		{
		}

		// Token: 0x0401B8F7 RID: 112887
		[Token(Token = "0x4018318")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C6A0", Offset = "0x18C7A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8F8 RID: 112888
		[Token(Token = "0x4018319")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C6E0", Offset = "0x18C7E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C6E0", Offset = "0x18C7E1")]
		public SharedFloat storeResult;

		// Token: 0x0401B8F9 RID: 112889
		[Token(Token = "0x401831A")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8FA RID: 112890
		[Token(Token = "0x401831B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
