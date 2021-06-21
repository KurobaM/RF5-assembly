using System;
using System.Collections.Generic;
using Define;
using DG.Tweening;
using Field;
using Funly.SkyStudio;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000314 RID: 788
[Token(Token = "0x2000254")]
public class SkyStudioTimeManager : SingletonMonoBehaviour<SkyStudioTimeManager>
{
	// Token: 0x170003AD RID: 941
	// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035F")]
	public TimeOfDayController TimeOfDayController
	{
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x1DED1C0", Offset = "0x1DED2C1", VA = "0x1DED1C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060014CA RID: 5322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000360")]
	public Light SunLight
	{
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x1DED1D0", Offset = "0x1DED2D1", VA = "0x1DED1D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x1DED1E0", Offset = "0x1DED2E1", VA = "0x1DED1E0")]
		private set
		{
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060014CC RID: 5324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000361")]
	public Light MoonLight
	{
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x1DED1F0", Offset = "0x1DED2F1", VA = "0x1DED1F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x1DED200", Offset = "0x1DED301", VA = "0x1DED200")]
		private set
		{
		}
	}

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x060014CD RID: 5325 RVA: 0x00009348 File Offset: 0x00007548
	[Token(Token = "0x17000362")]
	public bool IsDispWeatherEffect
	{
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x1DED210", Offset = "0x1DED311", VA = "0x1DED210")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x060014CE RID: 5326 RVA: 0x00009360 File Offset: 0x00007560
	// (set) Token: 0x060014CF RID: 5327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000363")]
	public FieldSceneData.Data SceneParam
	{
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x1DED240", Offset = "0x1DED341", VA = "0x1DED240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D070", Offset = "0x19D171")]
		get
		{
			return default(FieldSceneData.Data);
		}
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x1DED270", Offset = "0x1DED371", VA = "0x1DED270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D080", Offset = "0x19D181")]
		private set
		{
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000364")]
	private SkyProfile SceneSkyProfile
	{
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x1DED2A0", Offset = "0x1DED3A1", VA = "0x1DED2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D090", Offset = "0x19D191")]
		get
		{
			return null;
		}
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x1DED2B0", Offset = "0x1DED3B1", VA = "0x1DED2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0A0", Offset = "0x19D1A1")]
		set
		{
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000365")]
	private LensFlare LensFlare
	{
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x1DED2C0", Offset = "0x1DED3C1", VA = "0x1DED2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0B0", Offset = "0x19D1B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x1DED2D0", Offset = "0x1DED3D1", VA = "0x1DED2D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0C0", Offset = "0x19D1C1")]
		set
		{
		}
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x1DED2E0", Offset = "0x1DED3E1", VA = "0x1DED2E0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x1DED440", Offset = "0x1DED541", VA = "0x1DED440")]
	private void Start()
	{
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x1DED730", Offset = "0x1DED831", VA = "0x1DED730")]
	public void SetSceneSkyProfile(FieldSceneData.Data teleportSceneParam, string sceneName)
	{
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x00009378 File Offset: 0x00007578
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x1DED960", Offset = "0x1DEDA61", VA = "0x1DED960")]
	private bool CheckOverWriteWeather()
	{
		return default(bool);
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x1DEDC60", Offset = "0x1DEDD61", VA = "0x1DEDC60")]
	public void SetSceneSkyProfile()
	{
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x1DEDD90", Offset = "0x1DEDE91", VA = "0x1DEDD90")]
	public void SetCurrentSkyProfile()
	{
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x1DEE310", Offset = "0x1DEE411", VA = "0x1DEE310")]
	public void SetSkyProfile(SkyProfile skyProfile, bool isCopy = true)
	{
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x1DEE370", Offset = "0x1DEE471", VA = "0x1DEE370")]
	public void OnDayChangeSetWeather(int elapsedDay)
	{
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x1DEE990", Offset = "0x1DEEA91", VA = "0x1DEE990")]
	public void SetForceWeather(WeatherDay setForceWeather)
	{
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x1DEE850", Offset = "0x1DEE951", VA = "0x1DEE850")]
	public void SetWorkWeatherProfile()
	{
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x1DEEA90", Offset = "0x1DEEB91", VA = "0x1DEEA90")]
	public void CreateWeatherDayData(WeatherDay weatherDay, Weather[] skyWeathers)
	{
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x1DEE440", Offset = "0x1DEE541", VA = "0x1DEE440")]
	public void CreateWeatherDayData(WeatherDay weatherDay, Weather[] skyWeathers, ref SkyProfile workSkyProfile, bool isChangeProfile)
	{
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x1DEDAD0", Offset = "0x1DEDBD1", VA = "0x1DEDAD0")]
	private void SetLightningSpawnArea(SkyProfile skyProfile)
	{
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x1DF03A0", Offset = "0x1DF04A1", VA = "0x1DF03A0")]
	private void LoadWeatherEffect(WeatherDay weatherDay)
	{
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x1DF02D0", Offset = "0x1DF03D1", VA = "0x1DF02D0")]
	private void RemoveWeatherEffect(WeatherDay weatherDay)
	{
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x1DF0E80", Offset = "0x1DF0F81", VA = "0x1DF0E80")]
	private void LoadMeteorShower()
	{
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x1DF1630", Offset = "0x1DF1731", VA = "0x1DF1630")]
	private void RemoveMeteorShower()
	{
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x1DF1040", Offset = "0x1DF1141", VA = "0x1DF1040")]
	private void LoadRuneyEffect()
	{
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x1DF1740", Offset = "0x1DF1841", VA = "0x1DF1740")]
	private void RemoveRuneyEffect()
	{
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x00009390 File Offset: 0x00007590
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x1DF1250", Offset = "0x1DF1351", VA = "0x1DF1250")]
	private bool CheckLoadFireWork()
	{
		return default(bool);
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x000093A8 File Offset: 0x000075A8
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x1DF19E0", Offset = "0x1DF1AE1", VA = "0x1DF19E0")]
	private bool CheckRemoveFireWork()
	{
		return default(bool);
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x1DF12F0", Offset = "0x1DF13F1", VA = "0x1DF12F0")]
	private void LoadFireWork()
	{
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x1DF1A80", Offset = "0x1DF1B81", VA = "0x1DF1A80")]
	private void RemoveFireWork()
	{
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x000093C0 File Offset: 0x000075C0
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x1DF14A0", Offset = "0x1DF15A1", VA = "0x1DF14A0")]
	private bool CheckLoadConfetti()
	{
		return default(bool);
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x000093D8 File Offset: 0x000075D8
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x1DF1B90", Offset = "0x1DF1C91", VA = "0x1DF1B90")]
	private bool CheckRemoveConfetti()
	{
		return default(bool);
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x1DF1510", Offset = "0x1DF1611", VA = "0x1DF1510")]
	private void LoadConfetti()
	{
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x1DF1C00", Offset = "0x1DF1D01", VA = "0x1DF1C00")]
	private void RemoveConfetti()
	{
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x1DF1D10", Offset = "0x1DF1E11", VA = "0x1DF1D10")]
	public void SetLightEnabled(bool onoff)
	{
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x1DF1E00", Offset = "0x1DF1F01", VA = "0x1DF1E00")]
	private void LateUpdate()
	{
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x1DEDDE0", Offset = "0x1DEDEE1", VA = "0x1DEDDE0")]
	private void UpdateLight()
	{
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x1DF1EF0", Offset = "0x1DF1FF1", VA = "0x1DF1EF0")]
	private void UpdateWeatherEffect()
	{
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x1DF22C0", Offset = "0x1DF23C1", VA = "0x1DF22C0")]
	private void UpdateMeteorShower()
	{
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x1DF24E0", Offset = "0x1DF25E1", VA = "0x1DF24E0")]
	private void UpdateRuneyEffect()
	{
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x1DF2B90", Offset = "0x1DF2C91", VA = "0x1DF2B90")]
	private void UpdateFireWork()
	{
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x1DF2020", Offset = "0x1DF2121", VA = "0x1DF2020")]
	private void UpdateConfetti()
	{
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x1DEDB60", Offset = "0x1DEDC61", VA = "0x1DEDB60")]
	private void SetWeatherEffect()
	{
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x1DF1F60", Offset = "0x1DF2061", VA = "0x1DF1F60")]
	private void SetSkyTime(float ratio)
	{
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x1DF2DC0", Offset = "0x1DF2EC1", VA = "0x1DF2DC0")]
	public void ChangeTimeLine(SkyProfile profile, float startTime, float add, int dir)
	{
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x1DEEAA0", Offset = "0x1DEEBA1", VA = "0x1DEEAA0")]
	private void SetWeatherData(SkyProfile profile, float startTime, float duration, float jointDuration, Weather skyWeather, float shiftTimeStart, float shiftTimeLength, bool isLast)
	{
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x1DF08E0", Offset = "0x1DF09E1", VA = "0x1DF08E0")]
	private void AdjustAcrossDayWeather(SkyProfile todayProfile, SkyProfile yesterdayProfile, float targetTime, float jointDuration)
	{
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x1DEFFD0", Offset = "0x1DF00D1", VA = "0x1DEFFD0")]
	private void RemoveDummyKeyFrameData(SkyProfile profile)
	{
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x1DF0460", Offset = "0x1DF0561", VA = "0x1DF0460")]
	private void SetRainParam(SkyProfile changeProfile, SkyProfile referenceProfile)
	{
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x1DEE070", Offset = "0x1DEE171", VA = "0x1DEE070")]
	private void SetFogColor()
	{
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x1DED950", Offset = "0x1DEDA51", VA = "0x1DED950")]
	public void ResetFogColor()
	{
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x1DEE1A0", Offset = "0x1DEE2A1", VA = "0x1DEE1A0")]
	private void SetLensFlare()
	{
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x1DF3980", Offset = "0x1DF3A81", VA = "0x1DF3980")]
	private void SetCloud(SkyProfile changeProfile)
	{
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x000093F0 File Offset: 0x000075F0
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x1DF3940", Offset = "0x1DF3A41", VA = "0x1DF3940")]
	private bool IsBadWeather(Weather weather)
	{
		return default(bool);
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00009408 File Offset: 0x00007608
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x1DF3950", Offset = "0x1DF3A51", VA = "0x1DF3950")]
	private bool IsRainyWeather(Weather weather)
	{
		return default(bool);
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x1DF3C60", Offset = "0x1DF3D61", VA = "0x1DF3C60")]
	public void SetIndoorSkyProfile()
	{
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x1DF3C90", Offset = "0x1DF3D91", VA = "0x1DF3C90")]
	public void SetSkyProfile(int index)
	{
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x1DF3D20", Offset = "0x1DF3E21", VA = "0x1DF3D20")]
	public SkyStudioTimeManager()
	{
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x1DF50F0", Offset = "0x1DF51F1", VA = "0x1DF50F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D0D0", Offset = "0x19D1D1")]
	private void <LoadConfetti>b__105_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04000BE1 RID: 3041
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] texturePropertyKeys;

	// Token: 0x04000BE2 RID: 3042
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] colorPropertyKeys;

	// Token: 0x04000BE3 RID: 3043
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string[] numberPropertyKeys;

	// Token: 0x04000BE4 RID: 3044
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string[] boolPropertyKeys;

	// Token: 0x04000BE5 RID: 3045
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string[] badWeatherInvalidColorPropertyKeys;

	// Token: 0x04000BE6 RID: 3046
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x28")]
	private static readonly string[] badWeatherRefarColorPropertyKeys;

	// Token: 0x04000BE7 RID: 3047
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x30")]
	private static readonly string[] badWeatherInvalidNumberPropertyKeys;

	// Token: 0x04000BE8 RID: 3048
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x38")]
	private static readonly string[] badWeatherRefarNumberPropertyKeys;

	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x400090B")]
	private const float DefaultSunSize = 0.05f;

	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x400090C")]
	private const float CheckValueRateBefore = 0.248611107f;

	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x400090D")]
	private const float CheckValueRateAfter = 0.25f;

	// Token: 0x04000BEC RID: 3052
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TimeOfDayController _TimeOfDayController;

	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Light _SunLight;

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Light _MoonLight;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x30")]
	private bool _LightOff;

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x31")]
	private bool _CreateCopy;

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x38")]
	private SkyProfile _NowSkyProfile;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x40")]
	private SkyProfile _OldSkyProfile;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x48")]
	private SkyProfile _ForceSkyProfile;

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SkyProfile _BaseSkyProfile;

	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SkyProfile _WorkSkyProfile;

	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SkyProfile[] _WeatherSkyProfiles;

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SkyProfile _IndoorSkyProfile;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _LightningSpawnArea;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x78")]
	private int WeatherDayValue;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F780", Offset = "0x15F881")]
	private FieldSceneData.Data <SceneParam>k__BackingField;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F790", Offset = "0x15F891")]
	private SkyProfile <SceneSkyProfile>k__BackingField;

	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F7A0", Offset = "0x15F8A1")]
	private LensFlare <LensFlare>k__BackingField;

	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0xD8")]
	public Color AdjustFogColor;

	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0xE8")]
	public float AdjustFogColorRate;

	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0xEC")]
	public bool IsAdjustFogColor;

	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0xF0")]
	public float AdjustLuminanceRatio;

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Transform EffectPrefabRoot;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Transform MeteorShowerPrefabRoot;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000925")]
	private const int MeteorShowerPrefabId = 17389;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x108")]
	private GameObject MeteorShowerPrefab;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x110")]
	private ParticleSystem[] MeteorShowerParticles;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x118")]
	private bool IsActiveMeteorShower;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x119")]
	private bool IsLoadMeteorShower;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x400092A")]
	private const int RuneyEffectMax = 16;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x400092B")]
	private const int RuneyEffectInterval = 15;

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x400092C")]
	private const int RuneyEffectVariation = 15;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x400092D")]
	private const float RuneyEffectMoveDuration = 4f;

	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x400092E")]
	private const float RuneyEffectDelayDuration = 3.5f;

	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x400092F")]
	private const float RuneyEffectScale = 0.75f;

	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x4000930")]
	private const float RuneyEffectDistance = 0.5f;

	// Token: 0x04000C0F RID: 3087
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0x40")]
	private static readonly EffectID[] RuneyEffectIds;

	// Token: 0x04000C10 RID: 3088
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0x120")]
	private List<ParticleSystem> RuneyEffectPrefabs;

	// Token: 0x04000C11 RID: 3089
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0x128")]
	private List<ParticleSystem> RuneyEffectParticles;

	// Token: 0x04000C12 RID: 3090
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x130")]
	private int RuneyEffectIndex;

	// Token: 0x04000C13 RID: 3091
	[Token(Token = "0x4000935")]
	[FieldOffset(Offset = "0x134")]
	private int RuneyEffectIntervalCount;

	// Token: 0x04000C14 RID: 3092
	[Token(Token = "0x4000936")]
	private const int FireWorkPrefabId = 16174;

	// Token: 0x04000C15 RID: 3093
	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x138")]
	private GameObject FireWorkPrefab;

	// Token: 0x04000C16 RID: 3094
	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x140")]
	private ParticleSystem[] FireWorkParticles;

	// Token: 0x04000C17 RID: 3095
	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x148")]
	private bool IsActiveFireWork;

	// Token: 0x04000C18 RID: 3096
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x149")]
	private bool IsLoadFireWork;

	// Token: 0x04000C19 RID: 3097
	[Token(Token = "0x400093B")]
	private const int ConfettiPrefabId = 16173;

	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x150")]
	private GameObject ConfettiPrefab;

	// Token: 0x04000C1B RID: 3099
	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x158")]
	private ParticleSystem[] ConfettiParticles;

	// Token: 0x04000C1C RID: 3100
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x160")]
	private bool IsActiveConfetti;

	// Token: 0x04000C1D RID: 3101
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x161")]
	private bool IsLoadConfetti;

	// Token: 0x04000C1E RID: 3102
	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x164")]
	private float PrevDailyRatio;

	// Token: 0x04000C1F RID: 3103
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x168")]
	private float CheckDailyRatioChangeValue;

	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2001049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574F0", Offset = "0x1575F1")]
	private sealed class <>c__DisplayClass95_0
	{
		// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0x2251600", Offset = "0x2251701", VA = "0x2251600")]
		public <>c__DisplayClass95_0()
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0x2251610", Offset = "0x2251711", VA = "0x2251610")]
		internal void <LoadMeteorShower>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4018F51")]
		[FieldOffset(Offset = "0x10")]
		public SkyStudioTimeManager <>4__this;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4018F52")]
		[FieldOffset(Offset = "0x18")]
		public Transform parentTransform;
	}

	// Token: 0x02000316 RID: 790
	[Token(Token = "0x200104A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157500", Offset = "0x157601")]
	private sealed class <>c__DisplayClass97_0
	{
		// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x2251780", Offset = "0x2251881", VA = "0x2251780")]
		public <>c__DisplayClass97_0()
		{
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0x2251790", Offset = "0x2251891", VA = "0x2251790")]
		internal void <LoadRuneyEffect>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4018F53")]
		[FieldOffset(Offset = "0x10")]
		public SkyStudioTimeManager <>4__this;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4018F54")]
		[FieldOffset(Offset = "0x18")]
		public Transform parentTransform;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4018F55")]
		[FieldOffset(Offset = "0x20")]
		public UnityAction<ParticleSystem> <>9__0;
	}

	// Token: 0x02000317 RID: 791
	[Token(Token = "0x200104B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157510", Offset = "0x157611")]
	private sealed class <>c__DisplayClass101_0
	{
		// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D23")]
		[Address(RVA = "0x2251460", Offset = "0x2251561", VA = "0x2251460")]
		public <>c__DisplayClass101_0()
		{
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0x2251470", Offset = "0x2251571", VA = "0x2251470")]
		internal void <LoadFireWork>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4018F56")]
		[FieldOffset(Offset = "0x10")]
		public SkyStudioTimeManager <>4__this;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4018F57")]
		[FieldOffset(Offset = "0x18")]
		public Transform parentTransform;
	}

	// Token: 0x02000318 RID: 792
	[Token(Token = "0x200104C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157520", Offset = "0x157621")]
	private sealed class <>c__DisplayClass114_0
	{
		// Token: 0x0600150F RID: 5391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D25")]
		[Address(RVA = "0x22515E0", Offset = "0x22516E1", VA = "0x22515E0")]
		public <>c__DisplayClass114_0()
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D26")]
		[Address(RVA = "0x22515F0", Offset = "0x22516F1", VA = "0x22515F0")]
		internal void <UpdateRuneyEffect>b__0()
		{
		}

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4018F58")]
		[FieldOffset(Offset = "0x10")]
		public ParticleSystem effect;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4018F59")]
		[FieldOffset(Offset = "0x18")]
		public TweenCallback <>9__0;
	}
}
