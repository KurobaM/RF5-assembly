using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E16 RID: 3606
	[Token(Token = "0x200093B")]
	public class RainDownfallController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06005DCF RID: 24015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x23DACD0", Offset = "0x23DADD1", VA = "0x23DACD0")]
		public void SetWeatherEnclosure(WeatherEnclosure enclosure)
		{
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x23DB530", Offset = "0x23DB631", VA = "0x23DB530")]
		private void Update()
		{
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x23DAF20", Offset = "0x23DB021", VA = "0x23DAF20", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x23DB6A0", Offset = "0x23DB7A1", VA = "0x23DB6A0")]
		public RainDownfallController()
		{
		}

		// Token: 0x0400BDD2 RID: 48594
		[Token(Token = "0x4008E36")]
		[FieldOffset(Offset = "0x18")]
		public MeshRenderer rainMeshRenderer;

		// Token: 0x0400BDD3 RID: 48595
		[Token(Token = "0x4008E37")]
		[FieldOffset(Offset = "0x20")]
		public Material rainMaterial;

		// Token: 0x0400BDD4 RID: 48596
		[Token(Token = "0x4008E38")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x0400BDD5 RID: 48597
		[Token(Token = "0x4008E39")]
		[FieldOffset(Offset = "0x30")]
		private float m_TimeOfDay;

		// Token: 0x0400BDD6 RID: 48598
		[Token(Token = "0x4008E3A")]
		[FieldOffset(Offset = "0x38")]
		private SkyProfile m_SkyProfile;
	}
}
