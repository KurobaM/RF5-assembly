using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x02001346 RID: 4934
	[Token(Token = "0x2000D11")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D720", Offset = "0x14D821")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D720", Offset = "0x14D821")]
	public class IsPlaying : Conditional
	{
		// Token: 0x060073FD RID: 29693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B1")]
		[Address(RVA = "0x28D1890", Offset = "0x28D1991", VA = "0x28D1890", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x00028110 File Offset: 0x00026310
		[Token(Token = "0x60060B2")]
		[Address(RVA = "0x28D1990", Offset = "0x28D1A91", VA = "0x28D1990", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0x28D1A70", Offset = "0x28D1B71", VA = "0x28D1A70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0x28D1A80", Offset = "0x28D1B81", VA = "0x28D1A80")]
		public IsPlaying()
		{
		}

		// Token: 0x0401B6F0 RID: 112368
		[Token(Token = "0x4018111")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186830", Offset = "0x186931")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6F1 RID: 112369
		[Token(Token = "0x4018112")]
		[FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B6F2 RID: 112370
		[Token(Token = "0x4018113")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
