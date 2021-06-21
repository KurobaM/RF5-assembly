using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E17 RID: 3607
	[Token(Token = "0x200093C")]
	public class RainSplashController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06005DD3 RID: 24019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x23DB6D0", Offset = "0x23DB7D1", VA = "0x23DB6D0")]
		private void Start()
		{
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x23DB870", Offset = "0x23DB971", VA = "0x23DB870", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x23DB8B0", Offset = "0x23DB9B1", VA = "0x23DB8B0")]
		public void Update()
		{
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x23DB770", Offset = "0x23DB871", VA = "0x23DB770")]
		public void ClearSplashRenderers()
		{
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x23DBA80", Offset = "0x23DBB81", VA = "0x23DBA80")]
		public void CreateSplashRenderers()
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x23DBC80", Offset = "0x23DBD81", VA = "0x23DBC80")]
		public RainSplashController()
		{
		}

		// Token: 0x0400BDD7 RID: 48599
		[Token(Token = "0x4008E3B")]
		[FieldOffset(Offset = "0x18")]
		private SkyProfile m_SkyProfile;

		// Token: 0x0400BDD8 RID: 48600
		[Token(Token = "0x4008E3C")]
		[FieldOffset(Offset = "0x20")]
		private float m_TimeOfDay;

		// Token: 0x0400BDD9 RID: 48601
		[Token(Token = "0x4008E3D")]
		[FieldOffset(Offset = "0x28")]
		private List<RainSplashRenderer> m_SplashRenderers;
	}
}
