# *-* coding: utf-8 *-*
import re
import textwrap

# Просто скопированный текст из vin_info_ru.pdf.
a = "AA-AH ЮАР;AJ-AN Котд'Ивуар;AP-A0 не;используется;BA-BE Ангола;BF-BK Кения;BL-BR Танзания;BS-B0 не;используется;CA-CE Бенин;CFCK Мадагаскар;CL-CR Тунис;CS-C0 не;используется;DA-DE Египет;DF-DK Марокко;DL-DR Замбия;DS-D0 не;используется;EA-EE Эфиопия;EF-EK Мозамбик;EL-E0 не;используется;FA-FE Гана;FF-FK Нигерия;FL-F0 не;используется;GA-G0 не;используется;HA-H0 не;используется;JA-JT Япония;KA-KE Шри;Ланка;KFKK Израиль;KL-KR Южная;Корея;KSK0 Казахстан;LA-L0 Китай;MA-ME Индия;MFMK Индонези;я;MLMR Таиланд;MS-M0 не;используется;NFNK Пакистан;NL-NR Турция;NT-N0 не;используется;PAPE Филиппин;ы;PFPK Сингапур;PLPR Малайзия;PS-P0 не;используется;RA-RE ОАЭ;RFRK Тайвань;RLRR Вьетнам;RSR0 Саудовска;я Аравия;SASM Великобритани;я;SN-ST Германия;SU-SZ Польша;S1-S4 Латвия;TA-TH Швейцария;TJ-TP Чехия;TR-TV Венгрия;TW-T1 Португалия;T2-T0 не;используется;UA-UG не;используется;UH-UM Дания;UN-UT Ирландия;UU-UZ Румыния;U1-U4 не;используется;U5-U7 Словакия;U8-U0 не;используется;VA-VE Австрия;VF-VR Франция;VS-VW Испания;VX-V2 Сербия;V3-V5 Хорватия;V6-V0 Эстония;WA-W0 Германия;XA-XE Болгария;XF-XK Греция;XLXR Нидерланды;XS-XW СССР/СНГ;XX-X2 Люксембург;X3-X0 Россия;YA-YE Бельгия;YF-YK Финляндия;YL-YR Мальта;YS-YW Швеция;YX-Y2 Норвегия;Y3-Y5 Беларусь;Y6-Y0 Украина;ZA-ZR Италия;ZS-ZW не;1A-10 США;2A-20 Канада;3A3W Мексика;3X-37 Коста;Рика;38-;30 Кайманов;ы острова;4A-40 США;5A-50 США;6A-6W Австралия;6X-60 не;используется;7A-7E Новая;Зеландия;7F-70 не;используется;8A-8E Аргентина;8F-8K Чили;8L-8R Эквадор;8S-8W Перу;8X-82 Венесуэла;83-80 не;используется;9A-9E Бразилия;9F-9K Колумбия;9L-9R Парагвай;9S-9W Уругвай;9X-92 Тринидад и;Тобаго;93-99 Бразилия;ZX-Z2 Словения;Z3-Z5 Литва;Z6-Z0 Россия"
# Убираем все, что помечено как "не используется" в документе.
a = re.sub(r"[\s\S]{6}не;используется", r";", a)
# Фиксы строчек
a = re.sub(r";([\s\S]{1,9});", r" \g<1>;;", a)
a = re.sub(r";([A-Z0-9]{2}-);", r";\g<1>", a)
a = re.sub(r";([A-Z0-9]{2}-[A-Z0-9]{2}\s+[\S\s]+?) ([A-Z0-9]{2}-)", r"\g<1>;\g<2>", a)
a = re.sub(r"([A-Z0-9]{2})([A-Z0-9]{2})", r"\g<1>-\g<2>", a)
while re.findall(r"\s*;;", a):
    a = re.sub(r"\s*;;", r";", a)

for i in textwrap.wrap(a, 110):
    print('"' + i + ' " +')
