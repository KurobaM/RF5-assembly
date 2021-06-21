using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E1D RID: 3613
	[Token(Token = "0x2000942")]
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		// Token: 0x06005DFE RID: 24062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E15")]
		[Address(RVA = "0x23F0540", Offset = "0x23F0641", VA = "0x23F0540")]
		private void Start()
		{
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x23F0640", Offset = "0x23F0741", VA = "0x23F0640")]
		private void OnEnable()
		{
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x23F0650", Offset = "0x23F0751", VA = "0x23F0650")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x23F0780", Offset = "0x23F0881", VA = "0x23F0780")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x23F0550", Offset = "0x23F0651", VA = "0x23F0550")]
		public void ApplyEnclosure()
		{
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x23F0890", Offset = "0x23F0991", VA = "0x23F0890")]
		public WeatherEnclosureDetector()
		{
		}

		// Token: 0x0400BDF9 RID: 48633
		[Token(Token = "0x4008E5D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E6A0", Offset = "0x17E7A1")]
		public WeatherEnclosure mainEnclosure;

		// Token: 0x0400BDFA RID: 48634
		[Token(Token = "0x4008E5E")]
		[FieldOffset(Offset = "0x20")]
		private List<WeatherEnclosure> triggeredEnclosures;

		// Token: 0x0400BDFB RID: 48635
		[Token(Token = "0x4008E5F")]
		[FieldOffset(Offset = "0x28")]
		public RainDownfallController rainController;

		// Token: 0x0400BDFC RID: 48636
		[Token(Token = "0x4008E60")]
		[FieldOffset(Offset = "0x30")]
		public Action<WeatherEnclosure> enclosureChangedCallback;
	}
}
