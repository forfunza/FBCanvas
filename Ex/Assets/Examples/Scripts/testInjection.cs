using UnityEngine;
using System.Collections;

public class testInjection : MonoBehaviour {

	// Use this for initialization
	void Start () {

//		string strFacebookSDKScript = 
//			"(function(d, s, id) {" +
//				"console.log('d = ' + d,'s = '+s,'id = '+id);" +
//				"var js, fjs = d.getElementsByTagName(s)[0];" +
//				"if (d.getElementById(id)) return;" +
//				"js = d.createElement(s); js.id = id;" +
//				"js.async = true;" +
//				"js.src = \"//connect.facebook.net/en_US/sdk.js#xfbml=1&appId=280900645402047&version=v2.0\";" +
//				"fjs.parentNode.insertBefore(js, fjs);" +
//				"}(document, 'script', 'facebook-jssdk'));";
//		Application.ExternalEval(strFacebookSDKScript);


		string injection =
			//			"var script = document.createElement('script');" +
//				"script.onload = (function(d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = '//connect.facebook.net/en_US/sdk.js#xfbml=1&appId=382290415263069&version=v2.0'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));'"+
//				"var headerElement = document.createElement('div');" +
//				"headerElement.setAttribute('id', 'intro');" +
//				"headerElement.textContent = ('Check out our other great games: ... tttt');" +
				"var body = document.getElementsByTagName('body')[0];" +
				"body.style.textAlign = 'center';" +
				"body.style.background = 'url(\"http://www.bumres.com/build/logincanvasnew/img/bg.jpg\") top center';" +
//				background: url("http://www.bumres.com/build/logincanvasnew/img/bg.jpg") top center;
		"var insertionPoint = body.children[0]; " +
				"var unityPlayerEmbed = document.getElementById('unityPlayerEmbed').firstChild; " +
//				"unityPlayerEmbed.setAttribute('width', '760');"+
//				"unityPlayerEmbed.setAttribute('height', '500');"+
				"unityPlayerEmbed.setAttribute('style', 'display: block; width: 760px !important; height: 500px !important; margin: 10px auto;');";
//				"unityPlayerEmbed.style.width = '760px !important';"+
//				"unityPlayerEmbed.style.height = '500px !important';"+
//				"var fbLikeButton = document.createElement('div');" +
//				"fbLikeButton.setAttribute('class', 'fb-like');"+
//				"fbLikeButton.setAttribute('data-href', 'https://apps.facebook.com/382290415263069');"+
//				"fbLikeButton.setAttribute('data-layout', 'button_count');"+
//				"fbLikeButton.setAttribute('data-action', 'like');"+
//				"fbLikeButton.setAttribute('data-show-faces', 'true');"+
//				"fbLikeButton.setAttribute('data-share', 'false');"+
//				"if(document.getElementById('intro') == null){body.insertBefore(headerElement, insertionPoint);" +
//				"body.appendChild(fbLikeButton);}"; 

		Application.ExternalEval(injection);

		string injectionbottombanner =
			"var bottombanner = document.createElement('div');" +
				"bottombanner.setAttribute('id', 'btbanner');" +
				"bottombanner.setAttribute('style', 'display: block; width: 760px ; height: 255px ;background: url(http://www.bumres.com/build/logincanvasnew/img/banner-1.png) 50% 0%; margin: 0px auto; position: relative;');" +

			"var googlebutton = document.createElement('a');" +
				"googlebutton.setAttribute('href', 'http://www.google.com');" +
				"googlebutton.setAttribute('target', '_blank');" +
				"googlebutton.setAttribute('style', 'position: absolute; left: 30px; bottom: 10px');" +
			"var googleimage = document.createElement('img');" +
				"googleimage.setAttribute('src', 'http://www.bumres.com/build/logincanvasnew/img/btn-1.png');" +
				"googlebutton.appendChild(googleimage);" +
				"bottombanner.appendChild(googlebutton);" +

			"var applebutton = document.createElement('a');" +
				"applebutton.setAttribute('href', 'http://www.google.com');" +
				"applebutton.setAttribute('target', '_blank');" +
				"applebutton.setAttribute('style', 'position: absolute; left: 210px; bottom: 10px');" +
			"var appleimage = document.createElement('img');" +
				"appleimage.setAttribute('src', 'http://www.bumres.com/build/logincanvasnew/img/btn-2.png');" +
				"applebutton.appendChild(appleimage);" +
				"bottombanner.appendChild(applebutton);" +

			"var windowbutton = document.createElement('a');" +
				"windowbutton.setAttribute('href', 'http://www.google.com');" +
				"windowbutton.setAttribute('target', '_blank');" +
				"windowbutton.setAttribute('style', 'position: absolute; left: 388px; bottom: 10px');" +
			"var windowimage = document.createElement('img');" +
				"windowimage.setAttribute('src', 'http://www.bumres.com/build/logincanvasnew/img/btn-3.png');" +
				"windowbutton.appendChild(windowimage);" +
				"bottombanner.appendChild(windowbutton);" +

			"var amazonbutton = document.createElement('a');" +
				"amazonbutton.setAttribute('href', 'http://www.google.com');" +
				"amazonbutton.setAttribute('target', '_blank');" +
				"amazonbutton.setAttribute('style', 'position: absolute; right: 30px; bottom: 10px');" +
			"var amazonimage = document.createElement('img');" +
				"amazonimage.setAttribute('src', 'http://www.bumres.com/build/logincanvasnew/img/btn-4.png');" +
				"amazonbutton.appendChild(amazonimage);" +
				"bottombanner.appendChild(amazonbutton);" +
				"document.getElementsByTagName('body')[0].appendChild(bottombanner);";
		
		Application.ExternalEval(injectionbottombanner);


		string injectionfooter =
			"var footerbanner = document.createElement('div');" +
				"footerbanner.setAttribute('style', 'display: block; width: 760px ; margin: 10px auto; position: relative;');" +
			"var privacydiv = document.createElement('div');" +
				"privacydiv.setAttribute('style', 'float: right;');" +
			"var privacybutton = document.createElement('a');" +
				"privacybutton.setAttribute('href', 'http://www.google.com');" +
				"privacybutton.setAttribute('target', '_blank');" +
				"privacybutton.textContent = ('Privacy Policy | copyright@bumblissbulkypix');" +
				"privacydiv.appendChild(privacybutton);" +
//				"privacydiv.textContent = ('| copyright@bumblissbulkypix');"+
				"footerbanner.appendChild(privacydiv);" +

			"var fanpagebutton = document.createElement('a');" +
				"fanpagebutton.setAttribute('href', 'http://www.google.com');" +
				"fanpagebutton.setAttribute('target', '_blank');" +
				"fanpagebutton.setAttribute('style', 'float: left;');" +
			"var fanpageimg = document.createElement('img');" +
				"fanpageimg.setAttribute('src', 'http://www.bumres.com/build/logincanvasnew/img/fb-icon.png');" +
				"fanpageimg.setAttribute('style', 'vertical-align: middle;');" +
				"fanpagebutton.appendChild(fanpageimg);" +
				"fanpagebutton.innerHTML = fanpagebutton.innerHTML + ' FUSION TWO FAN PAGE';" +
				"footerbanner.appendChild(fanpagebutton);" +
				"document.getElementsByTagName('body')[0].appendChild(footerbanner);";
		
		Application.ExternalEval(injectionfooter);



//		string injectionads = 
//			"var googleadscript = document.createElement('script');" +
//			"googleadscript.async = true;" +
//			"googleadscript.src = '//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js';" +
//			"document.getElementsByTagName('head')[0].appendChild(googleadscript);" ;
//			
//		Application.ExternalEval(injectionads);
//
//
//		string injectionadsnew = 
//			"var googleadscriptnew = document.createElement('div');" +
//				"googleadscriptnew.setAttribute('class', 'row');" +
//			"var googleadscriptins = document.createElement('ins');" +
//				"googleadscriptins.style.display = 'inline-block';"+
//				"googleadscriptins.style.width = '728px';"+
//				"googleadscriptins.style.height = '90px';"+
//				"googleadscriptins.setAttribute('class', 'adsbygoogle');" +
//				"googleadscriptins.setAttribute('data-ad-client', 'ca-pub-6128762133900691');" +
//				"googleadscriptins.setAttribute('data-ad-slot', '4097402940');" +
//			"var adsbygooglescript = document.createElement('script');" +
//				"adsbygooglescript.textContent = '(adsbygoogle = window.adsbygoogle || []).push({})';" +
//				"googleadscriptins.appendChild(adsbygooglescript);" +
//				"googleadscriptnew.appendChild(googleadscriptins);" +
//				"document.getElementsByTagName('body')[0].appendChild(googleadscriptnew);" ;
//		
//		Application.ExternalEval(injectionadsnew);

//		<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
//
//		<div class="row">
//				<ins class="adsbygoogle"
//				style="display:inline-block;width:728px;height:90px"
//				data-ad-client="ca-pub-6128762133900691"
//				data-ad-slot="4097402940"></ins>
//				<script>
//				(adsbygoogle = window.adsbygoogle || []).push({});
//				</script>
//		</div>

	}



	// Update is called once per frame
	void Update () {
	
	}
}
