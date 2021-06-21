using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001425 RID: 5157
	[Token(Token = "0x2000DEB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152930", Offset = "0x152A31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152930", Offset = "0x152A31")]
	public class GetIntensity : Action
	{
		// Token: 0x06007703 RID: 30467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0x28E71F0", Offset = "0x28E72F1", VA = "0x28E71F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x00029580 File Offset: 0x00027780
		[Token(Token = "0x60063B8")]
		[Address(RVA = "0x28E72F0", Offset = "0x28E73F1", VA = "0x28E72F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B9")]
		[Address(RVA = "0x28E73E0", Offset = "0x28E74E1", VA = "0x28E73E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x28E7430", Offset = "0x28E7531", VA = "0x28E7430")]
		public GetIntensity()
		{
		}

		// Token: 0x0401B9E5 RID: 113125
		[Token(Token = "0x40183E3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E630", Offset = "0x18E731")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9E6 RID: 113126
		[Token(Token = "0x40183E4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E670", Offset = "0x18E771")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E670", Offset = "0x18E771")]
		public SharedFloat storeValue;

		// Token: 0x0401B9E7 RID: 113127
		[Token(Token = "0x40183E5")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9E8 RID: 113128
		[Token(Token = "0x40183E6")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
