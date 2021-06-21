using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001483 RID: 5251
	[Token(Token = "0x2000E49")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154C70", Offset = "0x154D71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154C70", Offset = "0x154D71")]
	public class GetPitch : Action
	{
		// Token: 0x06007857 RID: 30807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650B")]
		[Address(RVA = "0x28DA9F0", Offset = "0x28DAAF1", VA = "0x28DA9F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x00029E68 File Offset: 0x00028068
		[Token(Token = "0x600650C")]
		[Address(RVA = "0x28DAAF0", Offset = "0x28DABF1", VA = "0x28DAAF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650D")]
		[Address(RVA = "0x28DABE0", Offset = "0x28DACE1", VA = "0x28DABE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650E")]
		[Address(RVA = "0x28DAC30", Offset = "0x28DAD31", VA = "0x28DAC30")]
		public GetPitch()
		{
		}

		// Token: 0x0401BB10 RID: 113424
		[Token(Token = "0x401850E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191750", Offset = "0x191851")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB11 RID: 113425
		[Token(Token = "0x401850F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191790", Offset = "0x191891")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191790", Offset = "0x191891")]
		public SharedFloat storeValue;

		// Token: 0x0401BB12 RID: 113426
		[Token(Token = "0x4018510")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB13 RID: 113427
		[Token(Token = "0x4018511")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
