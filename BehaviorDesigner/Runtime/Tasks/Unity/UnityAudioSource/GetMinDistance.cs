using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001481 RID: 5249
	[Token(Token = "0x2000E47")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154BB0", Offset = "0x154CB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154BB0", Offset = "0x154CB1")]
	public class GetMinDistance : Action
	{
		// Token: 0x0600784F RID: 30799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006503")]
		[Address(RVA = "0x28DA540", Offset = "0x28DA641", VA = "0x28DA540", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x00029E38 File Offset: 0x00028038
		[Token(Token = "0x6006504")]
		[Address(RVA = "0x28DA640", Offset = "0x28DA741", VA = "0x28DA640", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006505")]
		[Address(RVA = "0x28DA730", Offset = "0x28DA831", VA = "0x28DA730", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006506")]
		[Address(RVA = "0x28DA780", Offset = "0x28DA881", VA = "0x28DA780")]
		public GetMinDistance()
		{
		}

		// Token: 0x0401BB08 RID: 113416
		[Token(Token = "0x4018506")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191630", Offset = "0x191731")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB09 RID: 113417
		[Token(Token = "0x4018507")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191670", Offset = "0x191771")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191670", Offset = "0x191771")]
		public SharedFloat storeValue;

		// Token: 0x0401BB0A RID: 113418
		[Token(Token = "0x4018508")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB0B RID: 113419
		[Token(Token = "0x4018509")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
