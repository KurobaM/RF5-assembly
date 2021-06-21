using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001499 RID: 5273
	[Token(Token = "0x2000E5F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1554B0", Offset = "0x1555B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1554B0", Offset = "0x1555B1")]
	public class SetScheduledEndTime : Action
	{
		// Token: 0x060078AF RID: 30895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006563")]
		[Address(RVA = "0x28DDCF0", Offset = "0x28DDDF1", VA = "0x28DDCF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x0002A078 File Offset: 0x00028278
		[Token(Token = "0x6006564")]
		[Address(RVA = "0x28DDDF0", Offset = "0x28DDEF1", VA = "0x28DDDF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006565")]
		[Address(RVA = "0x28DDEF0", Offset = "0x28DDFF1", VA = "0x28DDEF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006566")]
		[Address(RVA = "0x28DDF40", Offset = "0x28DE041", VA = "0x28DDF40")]
		public SetScheduledEndTime()
		{
		}

		// Token: 0x0401BB66 RID: 113510
		[Token(Token = "0x4018564")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192230", Offset = "0x192331")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB67 RID: 113511
		[Token(Token = "0x4018565")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192270", Offset = "0x192371")]
		public SharedFloat time;

		// Token: 0x0401BB68 RID: 113512
		[Token(Token = "0x4018566")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB69 RID: 113513
		[Token(Token = "0x4018567")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
