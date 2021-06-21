using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001485 RID: 5253
	[Token(Token = "0x2000E4B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154D30", Offset = "0x154E31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154D30", Offset = "0x154E31")]
	public class GetSpread : Action
	{
		// Token: 0x0600785F RID: 30815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006513")]
		[Address(RVA = "0x28DAEA0", Offset = "0x28DAFA1", VA = "0x28DAEA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x00029E98 File Offset: 0x00028098
		[Token(Token = "0x6006514")]
		[Address(RVA = "0x28DAFA0", Offset = "0x28DB0A1", VA = "0x28DAFA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006515")]
		[Address(RVA = "0x28DB090", Offset = "0x28DB191", VA = "0x28DB090", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006516")]
		[Address(RVA = "0x28DB0E0", Offset = "0x28DB1E1", VA = "0x28DB0E0")]
		public GetSpread()
		{
		}

		// Token: 0x0401BB18 RID: 113432
		[Token(Token = "0x4018516")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191870", Offset = "0x191971")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB19 RID: 113433
		[Token(Token = "0x4018517")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1918B0", Offset = "0x1919B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1918B0", Offset = "0x1919B1")]
		public SharedFloat storeValue;

		// Token: 0x0401BB1A RID: 113434
		[Token(Token = "0x4018518")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB1B RID: 113435
		[Token(Token = "0x4018519")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
