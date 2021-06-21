using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E14 RID: 3604
	[Token(Token = "0x2000939")]
	[Attribute(Name = "RequireComponent", RVA = "0x148EE0", Offset = "0x148FE1")]
	public class LightningRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06005DB8 RID: 23992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x23D7410", Offset = "0x23D7511", VA = "0x23D7410")]
		private void Start()
		{
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x0001F188 File Offset: 0x0001D388
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x23D74D0", Offset = "0x23D75D1", VA = "0x23D74D0", Slot = "4")]
		protected override Bounds CalculateMeshBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x23D75B0", Offset = "0x23D76B1", VA = "0x23D75B0", Slot = "5")]
		protected override BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x23D7620", Offset = "0x23D7721", VA = "0x23D7620", Slot = "6")]
		protected override bool IsRenderingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x23D7710", Offset = "0x23D7811", VA = "0x23D7710", Slot = "8")]
		protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x23D7BE0", Offset = "0x23D7CE1", VA = "0x23D7BE0", Slot = "9")]
		protected override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x23D7C70", Offset = "0x23D7D71", VA = "0x23D7C70", Slot = "10")]
		protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x23D7C80", Offset = "0x23D7D81", VA = "0x23D7C80", Slot = "11")]
		protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x23D7CF0", Offset = "0x23D7DF1", VA = "0x23D7CF0", Slot = "7")]
		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x23D7220", Offset = "0x23D7321", VA = "0x23D7220")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem)
		{
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x23D7D90", Offset = "0x23D7E91", VA = "0x23D7D90")]
		private void SyncDataFromSkyProfile()
		{
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x23D7980", Offset = "0x23D7A81", VA = "0x23D7980")]
		private LightningSpawnArea GetRandomLightningSpawnArea()
		{
			return null;
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x23D81E0", Offset = "0x23D82E1", VA = "0x23D81E0")]
		private void PlayThunderBoltSound()
		{
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x23D8310", Offset = "0x23D8411", VA = "0x23D8310")]
		public static void AddSpawnArea(LightningSpawnArea area)
		{
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x23D83E0", Offset = "0x23D84E1", VA = "0x23D83E0")]
		public static void RemoveSpawnArea(LightningSpawnArea area)
		{
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x23D7AF0", Offset = "0x23D7BF1", VA = "0x23D7AF0")]
		private Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area)
		{
			return default(Vector3);
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x23D7AB0", Offset = "0x23D7BB1", VA = "0x23D7AB0")]
		private float CalculateLightningBoltScaleForArea(LightningSpawnArea area)
		{
			return 0f;
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x23D84B0", Offset = "0x23D85B1", VA = "0x23D84B0")]
		public LightningRenderer()
		{
		}

		// Token: 0x0400BDC6 RID: 48582
		[Token(Token = "0x4008E2A")]
		[FieldOffset(Offset = "0x0")]
		private static List<LightningSpawnArea> m_SpawnAreas;

		// Token: 0x0400BDC7 RID: 48583
		[Token(Token = "0x4008E2B")]
		[FieldOffset(Offset = "0x88")]
		private float m_LightningProbability;

		// Token: 0x0400BDC8 RID: 48584
		[Token(Token = "0x4008E2C")]
		[FieldOffset(Offset = "0x8C")]
		private float m_NextSpawnTime;

		// Token: 0x0400BDC9 RID: 48585
		[Token(Token = "0x4008E2D")]
		[FieldOffset(Offset = "0x90")]
		private SkyProfile m_SkyProfile;

		// Token: 0x0400BDCA RID: 48586
		[Token(Token = "0x4008E2E")]
		[FieldOffset(Offset = "0x98")]
		private LightningArtItem m_Style;

		// Token: 0x0400BDCB RID: 48587
		[Token(Token = "0x4008E2F")]
		[FieldOffset(Offset = "0xA0")]
		private float m_TimeOfDay;

		// Token: 0x0400BDCC RID: 48588
		[Token(Token = "0x4008E30")]
		[FieldOffset(Offset = "0xA8")]
		private AudioSource m_AudioSource;

		// Token: 0x0400BDCD RID: 48589
		[Token(Token = "0x4008E31")]
		[FieldOffset(Offset = "0xB0")]
		private float m_LightningIntensity;

		// Token: 0x0400BDCE RID: 48590
		[Token(Token = "0x4008E32")]
		[FieldOffset(Offset = "0xB4")]
		private float m_ThunderSoundDelay;

		// Token: 0x0400BDCF RID: 48591
		[Token(Token = "0x4008E33")]
		[FieldOffset(Offset = "0xB8")]
		private float m_SpawnCoolDown;

		// Token: 0x0400BDD0 RID: 48592
		[Token(Token = "0x4008E34")]
		private const float k_ProbabiltyCheckInterval = 0.5f;
	}
}
