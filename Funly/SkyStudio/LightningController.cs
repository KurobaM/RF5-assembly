using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E13 RID: 3603
	[Token(Token = "0x2000938")]
	public class LightningController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06005DB2 RID: 23986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x23D6B60", Offset = "0x23D6C61", VA = "0x23D6B60")]
		private void Start()
		{
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x23D6D00", Offset = "0x23D6E01", VA = "0x23D6D00", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x23D6D40", Offset = "0x23D6E41", VA = "0x23D6D40")]
		public void Update()
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x23D6C00", Offset = "0x23D6D01", VA = "0x23D6C00")]
		public void ClearLightningRenderers()
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x23D7100", Offset = "0x23D7201", VA = "0x23D7100")]
		public void CreateLightningRenderers()
		{
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x23D7390", Offset = "0x23D7491", VA = "0x23D7390")]
		public LightningController()
		{
		}

		// Token: 0x0400BDC3 RID: 48579
		[Token(Token = "0x4008E27")]
		[FieldOffset(Offset = "0x18")]
		private SkyProfile m_SkyProfile;

		// Token: 0x0400BDC4 RID: 48580
		[Token(Token = "0x4008E28")]
		[FieldOffset(Offset = "0x20")]
		private float m_TimeOfDay;

		// Token: 0x0400BDC5 RID: 48581
		[Token(Token = "0x4008E29")]
		[FieldOffset(Offset = "0x28")]
		private List<LightningRenderer> m_LightningRenderers;
	}
}
