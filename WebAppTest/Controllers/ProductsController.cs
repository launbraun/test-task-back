﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAppTest.Models;
using System.Collections.ObjectModel;
using System.Web.Http.Cors;


namespace WebAppTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "http://localhost:3002/", headers: "*", methods: "*")]
    public class ProductsController : ControllerBase
    {
        
        private static List<Product> productList =

        new List<Product>
            {
            new Product
            {
        id = 0,
        title = "Псков – Печоры – Пушкинские Горы, 2 дня",
        header = "Автобусный тур выходного дня в Пушкинские Горы из Санкт-Петербурга в 2019 году по маршруту: Псков - Печоры - Пушкинские Горы.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Псков", "Печоры", "Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 26920.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3840b88a-859d-4dbb-9882-43f885c9cad1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3840b88a-859d-4dbb-9882-43f885c9cad1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/00636f43-90c9-4992-a907-5f269c90b66f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_00636f43-90c9-4992-a907-5f269c90b66f.jpg"
            }
            }
            },



            new Product
            {
        id = 1,
        title = "Курортный отдых в Старой Руссе",
        header = "Автобусный тур в Старую Руссу из Санкт-Петербурга на 2019 год.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Старая Русса" },
        minPrice = 14340.0,
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2b97aefb-6804-4937-9256-8497eaca19b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2b97aefb-6804-4937-9256-8497eaca19b5.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f16f6da5-6a15-48c5-8251-50d64439fceb.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f16f6da5-6a15-48c5-8251-50d64439fceb.jpg"
            },
            }
            },


                new Product
            {
        id = 2,
        title = "Великий Новгород – Валдай, 2 дня",
        header = "Автобусный тур выходного дня в Великий Новгород из Санкт-Петербурга на 2019 год по маршруту: Новгород – Валдай. с проживанием в отелях \"Парк Инн Великий Новгород\"****. \"Волхов\"**** или «Садко»***.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Валдай", "Великий Новгород" },
        periodStart = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg"
            },
            },


                 new Product
            {
        id = 3,
        title = "Псков – Изборск – Печоры – Пушкинские Горы, 3 дня",
        header = "Автобусный тур выходного дня в Пушкинские Горы из Санкт-Петербурга на 2019 год по маршруту: Псков – Изборск – Печоры – Пушкинские Горы. С экскурсией на пасеку «Пчелиная Усадьба».-",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Псков", "Изборск", "Печоры","Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 46400.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3840b88a-859d-4dbb-9882-43f885c9cad1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3840b88a-859d-4dbb-9882-43f885c9cad1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0bb1e678-bfba-4945-950c-5a7e567b3628.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0bb1e678-bfba-4945-950c-5a7e567b3628.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/83eb7124-c966-4dda-9155-9ee783a2079e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_83eb7124-c966-4dda-9155-9ee783a2079e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg"
            }
            }
            },


              new Product
            {
        id = 4,
        title = "Круиз на пароме «Princess Anastasia», 5 дней",
        header = "Круиз на пароме \"Принцесса Анастасия\" в Финляндию, Швецию и Эстонию из Санкт-Петербурга по маршруту: Хельсинки/Таллин - Стокгольм - Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Хельсинки","Таллин", "Стокгольм" },
        periodStart = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 12892.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/cc111af9-533a-4846-b9a3-31c92dbeb1e4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_cc111af9-533a-4846-b9a3-31c92dbeb1e4.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d56c631b-a6b5-4d3b-bc17-7f6eaaf66637.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d56c631b-a6b5-4d3b-bc17-7f6eaaf66637.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/23e6f71c-4fa5-4380-b38e-e72c3720a084.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_23e6f71c-4fa5-4380-b38e-e72c3720a084.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d27df564-1ae3-43cf-a271-d8c32e73a1dc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d27df564-1ae3-43cf-a271-d8c32e73a1dc.jpg"
            },
            }
            },

                new Product
            {
        id = 5,
        title = "Три дня в Таллине",
        header = "Автобусный тур на 3 дня в Таллин из Санкт-Петербурга.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Таллин" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 18, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 11088.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/22c77868-d732-4f1a-b25a-b169c68575bc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_22c77868-d732-4f1a-b25a-b169c68575bc.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpgg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/423e08dc-5f94-4f5b-b881-e611b691bac1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_423e08dc-5f94-4f5b-b881-e611b691bac1.jpg"
            },
            }
            },

             new Product
            {
        id = 6,
        title = "Пушкинские Горы, 2 дня",
        header = "Автобусный тур выходного дня в Пушкинские Горы из Санкт-Петербурга в 2019 году.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 26920.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/1f7ae7c1-1824-4a32-860a-8520792aa0b9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_1f7ae7c1-1824-4a32-860a-8520792aa0b9.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0abaa546-0357-4fff-9d24-44b77fde50b0.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0abaa546-0357-4fff-9d24-44b77fde50b0.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7a347b88-d0bc-4437-8c0d-5998636af1e0.jpgg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7d7e8579-6c84-4d61-8adb-f707de497668.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7d7e8579-6c84-4d61-8adb-f707de497668.JPG"
            }
            }
            },

                 new Product
            {
        id = 7,
        title = "Великий Новгород, 2 дня",
        header = "Автобусный тур выходного дня в Великий Новгород из Санкт-Петербурга на 2019 год . Проживание в отелях «Садко»***. \"Волхов\"**** или «Парк Инн Великий Новгород»****.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Великий Новгород" },
        periodStart = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 31, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 11960.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8872e8a8-daf8-4931-8705-927d453d037d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8872e8a8-daf8-4931-8705-927d453d037d.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8872e8a8-daf8-4931-8705-927d453d037d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8872e8a8-daf8-4931-8705-927d453d037d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/38832763-6100-478a-8545-30d354c5096f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_38832763-6100-478a-8545-30d354c5096f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4382f51-b16c-4cec-8b46-889052391a61.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4382f51-b16c-4cec-8b46-889052391a61.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c330af20-b432-46c1-8af3-127b80ec425f.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c330af20-b432-46c1-8af3-127b80ec425f.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7aeed9b4-0fea-4e75-99eb-7fb9b7061ce8.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7aeed9b4-0fea-4e75-99eb-7fb9b7061ce8.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4d10cf68-eab6-4bb3-8b83-13e4df1a7719.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4d10cf68-eab6-4bb3-8b83-13e4df1a7719.JPG"
            }
            }
            },

                     new Product
            {
        id = 8,
        title = "Сокровища Селигера, 3 дня",
        header = "Автобусный тур на Селигер в 2019 году из Санкт-Петербурга по маршруту: Валдай – Осташков – Нилова Пустынь – Торжок.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Валдай", "Заречье","Осташков","Нило-Столобенская пустынь", "Новые Ельцы", "Торжок" },
        periodStart = new DateTimeOffset(2019, 5, 10, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 12, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 34170.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/41654784-6f1b-4bc9-8fa1-11aad86a0d18.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_41654784-6f1b-4bc9-8fa1-11aad86a0d18.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d4514bad-bf34-4d6d-933c-11ea56e38403.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d4514bad-bf34-4d6d-933c-11ea56e38403.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg"
            },
              new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg"
            },
               new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7416d423-e385-4729-964b-f4c58bf3a932.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7416d423-e385-4729-964b-f4c58bf3a932.jpg"
            },
              new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/060d3fa1-a70e-4370-b85d-c256465c4675.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_060d3fa1-a70e-4370-b85d-c256465c4675.jpg"
            }
            }
            },

              new Product
            {
        id = 9,
        title = "Псковские крепости и древности",
        header = "Автобусный тур выходного дня в Псков из Санкт-Петербурга на 2019 год по маршруту: Псков – Печоры – д. Сигово – Изборск – Выбуты. С экскурсией в музей-усадьбу народа сето в деревне Сигово.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Псков","Печоры", "Изборск","Выбуты" },
        periodStart = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 14400.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0bb1e678-bfba-4945-950c-5a7e567b3628.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0bb1e678-bfba-4945-950c-5a7e567b3628.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3840b88a-859d-4dbb-9882-43f885c9cad1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3840b88a-859d-4dbb-9882-43f885c9cad1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpgg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/00636f43-90c9-4992-a907-5f269c90b66f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_00636f43-90c9-4992-a907-5f269c90b66f.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0bb1e678-bfba-4945-950c-5a7e567b3628.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0bb1e678-bfba-4945-950c-5a7e567b3628.jpg"
            },
              new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/83eb7124-c966-4dda-9155-9ee783a2079e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_83eb7124-c966-4dda-9155-9ee783a2079e.jpg"
            },
               new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg"
            },
                new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/907b0597-14db-4e53-8584-ffd5d73674c1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_907b0597-14db-4e53-8584-ffd5d73674c1.jpg"
            }
            }
            },

                  new Product
            {
        id = 10,
        title = "Старая Русса – Великий Новгород – Валдай",
        header = "Автобусный тур в Старую Руссу из Санкт-Петербурга на 2019 год по маршруту: Старая Русса – Великий Новгород – Валдай.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Старая Русса","Великий Новгород", "Валдай" },
        periodStart = new DateTimeOffset(2019, 5, 10, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 12, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 19574.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2b97aefb-6804-4937-9256-8497eaca19b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2b97aefb-6804-4937-9256-8497eaca19b5.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d3da8d89-f7c5-4e15-b74b-3d03a9727156.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f16f6da5-6a15-48c5-8251-50d64439fceb.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f16f6da5-6a15-48c5-8251-50d64439fceb.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2833e3a2-5a4b-41ca-8061-cb4f9b822b56.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2833e3a2-5a4b-41ca-8061-cb4f9b822b56.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/52b6b87a-8624-4810-ba27-5487fd208002.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_52b6b87a-8624-4810-ba27-5487fd208002.jpg"
            },
              new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG"
            },
               new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8872e8a8-daf8-4931-8705-927d453d037d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8872e8a8-daf8-4931-8705-927d453d037d.jpg"
            },
                new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/38832763-6100-478a-8545-30d354c5096f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_38832763-6100-478a-8545-30d354c5096f.jpg"
            },
                 new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4382f51-b16c-4cec-8b46-889052391a61.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4382f51-b16c-4cec-8b46-889052391a61.jpg"
            }
            }
            },


                    new Product
            {
        id = 11,
        title = "Отдых в Пушкинских Горах",
        header = "Автобусный тур в Пушкинские Горы из Санкт-Петербурга с отдыхом на турбазе «Пушкиногорье» летом и осенью 2019 года по маршруту: Псков - Печоры - Пушкинские Горы.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Псков", "Печоры", "Пушкинские Горы"},
        periodStart = new DateTimeOffset(2019, 5, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 70680.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/625758f4-5965-49b6-b0d0-2f56a86974e2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_625758f4-5965-49b6-b0d0-2f56a86974e2.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3840b88a-859d-4dbb-9882-43f885c9cad1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3840b88a-859d-4dbb-9882-43f885c9cad1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/00636f43-90c9-4992-a907-5f269c90b66f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_00636f43-90c9-4992-a907-5f269c90b66f.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0bb1e678-bfba-4945-950c-5a7e567b3628.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0bb1e678-bfba-4945-950c-5a7e567b3628.jpg"
            },
              new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/83eb7124-c966-4dda-9155-9ee783a2079e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_83eb7124-c966-4dda-9155-9ee783a2079e.jpg"
            },
               new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b3808c44-a37e-4bd6-8279-c9c4c7716290.jpg"
            },
                new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/907b0597-14db-4e53-8584-ffd5d73674c1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_907b0597-14db-4e53-8584-ffd5d73674c1.jpg"
            },
                 new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/753fa837-a77e-48c8-a58a-8349f9050b21.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_753fa837-a77e-48c8-a58a-8349f9050b21.jpg"
            }
            }
            },

  new Product
            {
        id = 12,
        title = "Сокровища Селигера, 5 дней",
        header = "Автобусный тур на Селигер в 2019 году из Санкт-Петербурга по маршруту: Валдай – Осташков – Нилова Пустынь – Торжок. С отдыхом на озере Селигер.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Валдай","Заречье","Осташков", "Волговерховье (Исток Волги)","Оковецкий святой ключ","Нило-Столобенская пустынь", "Торжок" },
        periodStart = new DateTimeOffset(2019, 6, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 54180.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/68c75e4d-9534-4f5d-8fcf-29ca336d346b.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_68c75e4d-9534-4f5d-8fcf-29ca336d346b.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d4514bad-bf34-4d6d-933c-11ea56e38403.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d4514bad-bf34-4d6d-933c-11ea56e38403.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg"
            }
            }
            },

    new Product
            {
        id = 13,
        title = "Отдых на Селигере",
        header = "Восьмидневный автобусный тур на Селигер в 2019 году из Санкт-Петербурга по маршруту: Валдай – Осташков – Нилова Пустынь – Торжок. с отдыхом в пансионате Сокол на берегу озера.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Валдай","Заречье", "Осташков", "Волговерховье (Исток Волги)", "Оковецкий святой ключ", "Нило-Столобенская пустынь","Торжок"},
        periodStart = new DateTimeOffset(2019, 6, 21, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 88410.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c01fe1c0-6c30-4953-b0cb-bc30c867125f.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c01fe1c0-6c30-4953-b0cb-bc30c867125f.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d4514bad-bf34-4d6d-933c-11ea56e38403.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d4514bad-bf34-4d6d-933c-11ea56e38403.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7416d423-e385-4729-964b-f4c58bf3a932.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7416d423-e385-4729-964b-f4c58bf3a932.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/060d3fa1-a70e-4370-b85d-c256465c4675.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_060d3fa1-a70e-4370-b85d-c256465c4675.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3511d87d-934d-4c05-858d-8588c8974c57.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3511d87d-934d-4c05-858d-8588c8974c57.jpg"
            }
            }
            },

            new Product
            {
        id = 14,
        title = "Финляндия - Швеция, 3 дня (линия Хельсинки)",
        header = "Круиз на пароме в Стокгольм из Санкт-Петербурга по маршруту: Хельсинки -  Стокгольм - Хельсинки. Отправление парома из Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Хельсинки", "Стокгольм"},
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 18, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 5358.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            }
            }
            },

              new Product
            {
        id = 15,
        title = "Финляндия - Швеция, 3 дня (линия Турку)",
        header = "Круиз на пароме в Стокгольм из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм - Турку. Отправление парома из Турку.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки","Турку","Стокгольм"},
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 18, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 4928.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e878cc20-34c8-4b71-a5df-cb565ec32c84.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e878cc20-34c8-4b71-a5df-cb565ec32c84.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            }
            }
            },

                new Product
            {
        id = 16,
        title = "Хельсинки, 2 дня",
        header = "Экскурсионный двухдневный автобусный тур выходного дня в Хельсинки из Санкт-Петербурга.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Хельсинки" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 12290.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            }
            }
            },
                  new Product
            {
        id = 17,
        title = "Золотая осень в Пушкинских Горах",
        header = "Автобусный тур в Пушкинские Горы из Санкт-Петербурга осенью 2019 года.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 9, 13, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 9, 15, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 49000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9addc0f7-3b13-485a-93bf-78c514016eb4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9addc0f7-3b13-485a-93bf-78c514016eb4.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0abaa546-0357-4fff-9d24-44b77fde50b0.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0abaa546-0357-4fff-9d24-44b77fde50b0.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7d7e8579-6c84-4d61-8adb-f707de497668.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7d7e8579-6c84-4d61-8adb-f707de497668.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f190dcd3-b644-41af-9f86-5f898fd2c64f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f190dcd3-b644-41af-9f86-5f898fd2c64f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/626d19f2-e5dc-4210-84b2-95e38de1dd8d.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_626d19f2-e5dc-4210-84b2-95e38de1dd8d.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/20602ccc-c5dd-4082-a198-a68252a2d900.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_20602ccc-c5dd-4082-a198-a68252a2d900.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3c94b4ce-5c5d-4ada-8090-82a901e6b17f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3c94b4ce-5c5d-4ada-8090-82a901e6b17f.jpg"
            }
            }
            },

                    new Product
            {
        id = 18,
        title = "Финляндия - Швеция, 4 дня (линия Хельсинки)",
        header = "Круиз на пароме в Стокгольм из Санкт-Петербурга по маршруту: Хельсинки - Стокгольм - Хельсинки. Отправление парома из Хельсинки. ",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки","Стокгольм" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 26, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 10234.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/40be2447-2d15-4694-a29a-b7f39602f73e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_40be2447-2d15-4694-a29a-b7f39602f73e.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            }
            }
            },

                      new Product
            {
        id = 19,
        title = "Иматра, 2 дня",
        header = "Тур выходного дня на автобусе в Иматру из Санкт-Петербурга с проживанием в SPA-отелях.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Иматра"},
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15146.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d65567d7-9676-43bd-abb0-93579f0288b2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d65567d7-9676-43bd-abb0-93579f0288b2.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2d77921e-afa1-480c-9f08-7d8177211157.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2d77921e-afa1-480c-9f08-7d8177211157.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d12a7ff-7134-4178-896c-02efb104f55b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d12a7ff-7134-4178-896c-02efb104f55b.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/da502cd1-24a6-44e0-8d28-7741f8f8cf62.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_da502cd1-24a6-44e0-8d28-7741f8f8cf62.jpg"
            }
            }
            },

             new Product
            {
        id = 20,
        title = "Финляндия - Швеция, 4 дня (линия Турку)",
        header = "Круиз на пароме в Стокгольм из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм.  Отправление парома из Турку.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки","Турку", "Стокгольм" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 26, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 9568.5,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8215ff21-0840-4c5c-8b31-da7c30acf924.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8215ff21-0840-4c5c-8b31-da7c30acf924.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
             
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            }
            }
            },

               new Product
            {
        id = 21,
        title = "Два дня в Таллине",
        header = "Экскурсионный тур на 2 дня в Таллин из Санкт-Петербурга на рейсовых автобусах или на поезде.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Таллин" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 7530.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d95c16de-08e6-4e97-8ebb-ad620f6a8311.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d95c16de-08e6-4e97-8ebb-ad620f6a8311.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/423e08dc-5f94-4f5b-b881-e611b691bac1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_423e08dc-5f94-4f5b-b881-e611b691bac1.jpg"
            }
            }
            },


             new Product
            {
        id = 22,
        title = "Хельсинки - Порвоо, 3 дня",
        header = "Автобусный тур выходного дня в Финляндию из Санкт-Петербурга по маршруту: Хельсинки - Порвоо.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки", "Порвоо" },
        periodStart = new DateTimeOffset(2019, 3, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 22748.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            }
            }
            },

            new Product
            {
        id = 23,
        title = "Три столицы Балтики",
        header = "Экскурсионный тур на автобусе и пароме в Латвию, Швецию и Эстонию из Санкт-Петербурга  по маршруту: Рига - Стокгольм - Таллин.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Рига","Стокгольм", "Таллин" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 6495.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/539dd28c-df74-4c93-8d66-e5f384994888.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_539dd28c-df74-4c93-8d66-e5f384994888.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9d3067c1-0832-4816-b14c-6523b5dd9582.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9d3067c1-0832-4816-b14c-6523b5dd9582.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/00636f43-90c9-4992-a907-5f269c90b66f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_00636f43-90c9-4992-a907-5f269c90b66f.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4c18361-9a6c-4025-9325-8c911344e720.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4c18361-9a6c-4025-9325-8c911344e720.JPG"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/901903f1-7db0-41ca-be5f-26e582451897.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_901903f1-7db0-41ca-be5f-26e582451897.JPG"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/539dd28c-df74-4c93-8d66-e5f384994888.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_539dd28c-df74-4c93-8d66-e5f384994888.jpg"
            }
            }
            },

              new Product
            {
        id = 24,
        title = "Тверь для гурманов и не только...",
        header = "Автобусный тур в Тверь из Санкт-Петербурга в 2019 году по маршруту: Тверь – Домотканово – село Медное.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Тверь", "Домотканово", "Медное" },
        periodStart = new DateTimeOffset(2019, 7, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 24946.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/bfb7e59e-b497-4d2c-9fbd-b3f4bf7bf905.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_bfb7e59e-b497-4d2c-9fbd-b3f4bf7bf905.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c6de69de-d2e9-4b9e-a0de-b8b1dc684f6d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c6de69de-d2e9-4b9e-a0de-b8b1dc684f6d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/51933351-49c2-45e1-a123-16e17fecc693.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_51933351-49c2-45e1-a123-16e17fecc693.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/aed16c9f-0446-406b-a165-81f18a6f40e9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_aed16c9f-0446-406b-a165-81f18a6f40e9.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b4504877-012a-42d5-bb6d-1e38c5ef3b2d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b4504877-012a-42d5-bb6d-1e38c5ef3b2d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8f23cb89-f9f9-4b18-be52-30a2849022db.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8f23cb89-f9f9-4b18-be52-30a2849022db.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f071f890-920a-4f8a-bea6-95c6c986b7a3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f071f890-920a-4f8a-bea6-95c6c986b7a3.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/bfb7e59e-b497-4d2c-9fbd-b3f4bf7bf905.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_bfb7e59e-b497-4d2c-9fbd-b3f4bf7bf905.jpg"
            }
            }
            },

                new Product
            {
        id = 25,
        title = "Таллин - три водопада",
        header = "Групповой автобусный тур на 2 дня в Таллин из Санкт-Петербурга по маршруту: Обрыв Гамлета - водопад Кейла-Йоа - замок Фалль в имении Бенкендорфов - Волконских - замок Маарьянмаги - водопад Ягала - Ганзейский Ревель - водопад Валасте - Замок Раквере.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Таллин" },
        periodStart = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 31, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 12706.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/423e08dc-5f94-4f5b-b881-e611b691bac1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_423e08dc-5f94-4f5b-b881-e611b691bac1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/22c77868-d732-4f1a-b25a-b169c68575bc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_22c77868-d732-4f1a-b25a-b169c68575bc.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5c5b2d58-3fc1-4b82-a729-e4421217b903.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5c5b2d58-3fc1-4b82-a729-e4421217b903.jpg"
            }
            }
            },

  new Product
            {
        id = 26,
        title = "Эстония - Швеция - Финляндия",
        header = "Автобусный экскурсионный тур  из Санкт-Петербурга с круизом на пароме  по маршруту Таллин - Стокгольм - Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Таллин", "Стокгольм", "Хельсинки" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 22996.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d0778701-1938-474b-af8d-1e2c01af791f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d0778701-1938-474b-af8d-1e2c01af791f.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpg"
            }
            }
            },

    new Product
            {
        id = 27,
        title = "Тур на Аландские острова (вариант 2)",
        header = "Экскурсионный тур в Финляндию на Аландские острова по маршруту: Турку- Аландские острова - Хельсинки - Порвоо.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Турку", "Мариехамн",  "Хельсинки", "Порвоо" },
        periodStart = new DateTimeOffset(2019, 6, 14, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 23730.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/47350d11-5e1a-468f-88f0-c3892e773d49.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_47350d11-5e1a-468f-88f0-c3892e773d49.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/47350d11-5e1a-468f-88f0-c3892e773d49.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_47350d11-5e1a-468f-88f0-c3892e773d49.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/436327c0-3b94-43fb-9d71-fc3b35e4a16c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_436327c0-3b94-43fb-9d71-fc3b35e4a16c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ff1ba9ac-d3ce-46d8-a9a9-dbde949732f9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ff1ba9ac-d3ce-46d8-a9a9-dbde949732f9.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b2e2fd1f-f5c7-4c36-95e7-bc5868e4d18b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b2e2fd1f-f5c7-4c36-95e7-bc5868e4d18b.jpg"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/49c3c464-4aef-4452-8de9-ad14a9d91d27.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_49c3c464-4aef-4452-8de9-ad14a9d91d27.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ca03cde7-f23e-4cda-8592-71bd935750ee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ca03cde7-f23e-4cda-8592-71bd935750ee.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/38122e19-ce64-4130-b4ae-ad1696ef68fc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_38122e19-ce64-4130-b4ae-ad1696ef68fc.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/affb045b-b983-4415-8b64-11df082a1a9c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_affb045b-b983-4415-8b64-11df082a1a9c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/1c3c445c-14e5-42d5-8acc-2c85ff4b9a04.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_1c3c445c-14e5-42d5-8acc-2c85ff4b9a04.jpg"
            }
            }
            },

      new Product
            {
        id = 28,
        title = "Рига – Таллин",
        header = "Экскурсионный автобусный тур в Прибалтику из Санкт-Петербурга по маршруту: Рига - Таллин.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Рига", "Таллин"},
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 27557.28,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9d3067c1-0832-4816-b14c-6523b5dd9582.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9d3067c1-0832-4816-b14c-6523b5dd9582.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4c18361-9a6c-4025-9325-8c911344e720.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4c18361-9a6c-4025-9325-8c911344e720.JPG"
            },
             new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/901903f1-7db0-41ca-be5f-26e582451897.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_901903f1-7db0-41ca-be5f-26e582451897.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg"
            },
            }
            },

        new Product
            {
        id = 29,
        title = "Вильнюс - Рига - Стокгольм - Таллин",
        header = "Экскурсионный тур на автобусе и пароме  по Скандинавии и Прибалтике по маршруту: Вильнюс  - Рига - Стокгольм - Таллин.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Вильнюс","Рига", "Стокгольм", "Таллин"},
        periodStart = new DateTimeOffset(2019, 3, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 31, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 9568.5,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/97978672-75f3-45bc-80a1-b79c180e1413.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_97978672-75f3-45bc-80a1-b79c180e1413.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3faa76eb-41fd-4060-be43-a59f246d490a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3faa76eb-41fd-4060-be43-a59f246d490a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/66b8008a-49f9-48a6-b133-7b47efec15c2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_66b8008a-49f9-48a6-b133-7b47efec15c2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/84b708df-ce4d-406c-b2ca-f1d1a9946d40.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_84b708df-ce4d-406c-b2ca-f1d1a9946d40.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/95a909c4-32bd-4ed9-bd36-2845d8314320.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_95a909c4-32bd-4ed9-bd36-2845d8314320.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d2508b0f-5d01-4707-9e15-5c20cdcb9d26.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d2508b0f-5d01-4707-9e15-5c20cdcb9d26.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b93ee6bc-c1f1-44cf-b274-e6d7f61bc7a8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b93ee6bc-c1f1-44cf-b274-e6d7f61bc7a8.jpg"
            }
            }
            },

            new Product
            {
        id = 30,
        title = "Четыре столицы Балтики",
        header = "Автобусный тур из Санкт-Петербурга с круизом в Стокгольм по маршруту: Таллин - Рига - Стокгольм - Хельсинки. ",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Таллин", "Рига", "Стокгольм", "Хельсинки" },
        periodStart = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 9568.5,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            }
            }
            },

                new Product
            {
        id = 31,
        title = "Средневековый Таллин",
        header = "Экскурсионный тур на автобусе в Эстонию из Санкт-Петербурга по маршруту: Таллин - Саарема - Раквере.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Таллин", "Сааремаа", "Раквере"},
        periodStart = new DateTimeOffset(2019, 5, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 16812.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5302b9cf-fa9d-41e6-afd7-70115802c907.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5302b9cf-fa9d-41e6-afd7-70115802c907.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/423e08dc-5f94-4f5b-b881-e611b691bac1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_423e08dc-5f94-4f5b-b881-e611b691bac1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/22c77868-d732-4f1a-b25a-b169c68575bc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_22c77868-d732-4f1a-b25a-b169c68575bc.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5c5b2d58-3fc1-4b82-a729-e4421217b903.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5c5b2d58-3fc1-4b82-a729-e4421217b903.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b2d2687e-5f84-49bd-a2b1-422e1ba6cc67.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b2d2687e-5f84-49bd-a2b1-422e1ba6cc67.jpg"
            }
            }
            },

                    new Product
            {
        id = 32,
        title = "Две столицы, два Кремля",
        header = "Автобусный тур выходного дня в Великий Новгород и Псков в 2019 году.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Великий Новгород","Псков" },
        periodStart = new DateTimeOffset(2019, 6, 15, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 13900.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/de6a8230-8199-4fcd-9bcd-1ac86b20cc70.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_de6a8230-8199-4fcd-9bcd-1ac86b20cc70.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e0b22b2b-7012-4460-a9b6-6ca357650eb2.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8872e8a8-daf8-4931-8705-927d453d037d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8872e8a8-daf8-4931-8705-927d453d037d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/38832763-6100-478a-8545-30d354c5096f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_38832763-6100-478a-8545-30d354c5096f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4382f51-b16c-4cec-8b46-889052391a61.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4382f51-b16c-4cec-8b46-889052391a61.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c330af20-b432-46c1-8af3-127b80ec425f.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c330af20-b432-46c1-8af3-127b80ec425f.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7aeed9b4-0fea-4e75-99eb-7fb9b7061ce8.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7aeed9b4-0fea-4e75-99eb-7fb9b7061ce8.JPG"
            }
            }
            },

                        new Product
            {
        id = 33,
        title = "Кулинарные традиции Таллина",
        header = "Гастрономический тур в Таллин из Санкт-Петербурга на автобусе.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Таллин"},
        periodStart = new DateTimeOffset(2019, 3, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 21128.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a76b3962-77f9-4ab3-8a23-008dd0339c96.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a76b3962-77f9-4ab3-8a23-008dd0339c96.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/03666646-f4fb-4999-adcc-8cab1a76621e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_03666646-f4fb-4999-adcc-8cab1a76621e.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/423e08dc-5f94-4f5b-b881-e611b691bac1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_423e08dc-5f94-4f5b-b881-e611b691bac1.jpg"
            }
            }
            },

            new Product
            {
        id = 34,
        title = "Релакс-тур на Селигер, 5 дней",
        header = "Автобусный тур на Селигер из Санкт-Петербурга по маршруту: Валдай – Светлица - Осташков – Нилова Пустынь – Оковецкий Святой ключ - Торжок. Размещение в загородном отеле \"Светлица\".",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Оковецкий святой ключ","Валдай", "Светлица",  "Осташков", "Нило-Столобенская пустынь", "Торжок" },
        periodStart = new DateTimeOffset(2019, 7, 15, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 19, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 44214.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/75b86d22-2663-4202-bf92-8ea7d84c36f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_75b86d22-2663-4202-bf92-8ea7d84c36f7.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/02c01e31-1511-4310-bfe3-f83d49bd8750.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_02c01e31-1511-4310-bfe3-f83d49bd8750.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/75b86d22-2663-4202-bf92-8ea7d84c36f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_75b86d22-2663-4202-bf92-8ea7d84c36f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fa852af5-2985-4584-8fbc-5d36bdf638f2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fa852af5-2985-4584-8fbc-5d36bdf638f2.jpg"
            }
            }
            },

                new Product
            {
        id = 35,
        title = "Тур на Аландские острова (вариант 1)",
        header = "Круиз на пароме на Аландские острова из Санкт-Петербурга по маршруту: Котка - Аландские острова - Хельсинки - Порвоо. ",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Котка", "Хельсинки","Мариехамн" },
        periodStart = new DateTimeOffset(2019, 5, 9, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 11, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 14544.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f0416c49-f71b-4843-8a9a-c2475e831903.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f0416c49-f71b-4843-8a9a-c2475e831903.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/714b5bc4-2979-479c-9259-6e5e066f7389.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_714b5bc4-2979-479c-9259-6e5e066f7389.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f7dcbf7b-ad1e-41bf-9c7d-1e4ff3c1927b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f7dcbf7b-ad1e-41bf-9c7d-1e4ff3c1927b.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/144964fe-6394-444f-90a6-bd5d60cde17a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_144964fe-6394-444f-90a6-bd5d60cde17a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f0416c49-f71b-4843-8a9a-c2475e831903.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f0416c49-f71b-4843-8a9a-c2475e831903.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0aa2b873-7964-4f69-bd9c-e2c28d8e2d65.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0aa2b873-7964-4f69-bd9c-e2c28d8e2d65.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f9b01a1c-4550-4293-ad35-f3bfe1e705f8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f9b01a1c-4550-4293-ad35-f3bfe1e705f8.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/63391938-1968-4bd1-8ca2-cf1ce5d7b52c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_63391938-1968-4bd1-8ca2-cf1ce5d7b52c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/27ad8c80-f2a0-47bb-b2d3-db69322267ff.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_27ad8c80-f2a0-47bb-b2d3-db69322267ff.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/91e1b162-5859-4729-b7ba-f8e522bf0e07.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_91e1b162-5859-4729-b7ba-f8e522bf0e07.jpg"
            }
            }
            },
                    new Product
            {
        id = 36,
        title = "Отдых на Валдае",
        header = "Автобусный тур из Санкт-Петербурга на 2019 год по маршруту: Ижицы – Валдай – Крестцы. С проживание в отеле «Валдайские зори» на берегу Валдайского озера.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Ижицы","Валдай","Крестцы"},
        periodStart = new DateTimeOffset(2019, 5, 10, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 11, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 13034.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/060d3fa1-a70e-4370-b85d-c256465c4675.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_060d3fa1-a70e-4370-b85d-c256465c4675.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d4514bad-bf34-4d6d-933c-11ea56e38403.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d4514bad-bf34-4d6d-933c-11ea56e38403.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_32f7e1bb-5518-4c87-acda-6fd83520ceee.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7c6c71f6-46a4-41d7-8cb6-4685e2b1800d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b36783d0-fd08-4d87-a2e3-eb21ff1031fc.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dee26ce4-7c71-436e-a34f-5211b2c792e5.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0f0a0f7a-e59b-4727-957a-97c982f3608e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7416d423-e385-4729-964b-f4c58bf3a932.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7416d423-e385-4729-964b-f4c58bf3a932.jpg"
            }
            }
            },

             new Product
            {
        id = 37,
        title = "Старая Ладога, 1 день",
        header = "Однодневная экскурсия в Старую Ладогу из Санкт-Петербурга в 2019 году.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Старая Ладога"},
        periodStart = new DateTimeOffset(2019, 4, 13, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 13, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 1990.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dc7ea6bb-4043-41b9-a8be-7215cb506be8.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dc7ea6bb-4043-41b9-a8be-7215cb506be8.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/292acfd5-0adb-43f5-a0c6-2773418a7d52.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_292acfd5-0adb-43f5-a0c6-2773418a7d52.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ab04a9aa-85f9-4141-8ee2-7f6a2df9fed5.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ab04a9aa-85f9-4141-8ee2-7f6a2df9fed5.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b231d052-197d-452f-bf66-313fd6ab4b61.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b231d052-197d-452f-bf66-313fd6ab4b61.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/977ff5a5-3afb-4157-90a0-6cc82f92ee13.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_977ff5a5-3afb-4157-90a0-6cc82f92ee13.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/aa90ff28-03d2-4fc0-ac79-14cebbd1e37d.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_aa90ff28-03d2-4fc0-ac79-14cebbd1e37d.JPG"
            }
            }
            },


                 new Product
            {
        id = 38,
        title = "Очарование Латвии ",
        header = "Экскурсионный тур в Ригу из Санкт-Петербурга по маршруту: Рига – Сигулда – Юрмала.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Рига","Сигулда","Юрмала" },
        periodStart = new DateTimeOffset(2019, 3, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 31, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 20134.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/47e968eb-e465-46e0-950a-b8ad738a9e48.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_47e968eb-e465-46e0-950a-b8ad738a9e48.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9d3067c1-0832-4816-b14c-6523b5dd9582.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9d3067c1-0832-4816-b14c-6523b5dd9582.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4c18361-9a6c-4025-9325-8c911344e720.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4c18361-9a6c-4025-9325-8c911344e720.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/901903f1-7db0-41ca-be5f-26e582451897.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_901903f1-7db0-41ca-be5f-26e582451897.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg"
            },
            }
            },

                     new Product
            {
        id = 39,
        title = "Круиз на пароме «Princess Anastasia», 3 дня",
        header = "Круиз на пароме \"Принцесса Анастасия\" в Финляндию из Санкт-Петербурга по маршруту: Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки"},
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 5760.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2ad21910-12ae-45a0-b387-a2b19785a7c3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2ad21910-12ae-45a0-b387-a2b19785a7c3.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2ad21910-12ae-45a0-b387-a2b19785a7c3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2ad21910-12ae-45a0-b387-a2b19785a7c3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4bd0f9c0-203e-4bf6-8cd3-3d967c2ce9f8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4bd0f9c0-203e-4bf6-8cd3-3d967c2ce9f8.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/708e7158-809c-45a9-aae3-1e053f6f2d72.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_708e7158-809c-45a9-aae3-1e053f6f2d72.jpg"
            }
            }
            },

                         new Product
            {
        id = 40,
        title = "Хельсинки, 3 дня",
        header = "Экскурсионный трёхдневный автобусный тур выходного дня в Хельсинки из Санкт-Петербурга.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки" },
        periodStart = new DateTimeOffset(2019, 3, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 21180.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            }
            }
            },


            new Product
            {
        id = 41,
        title = "Северная корона на майские праздники",
        header = "Экскурсионный тур на майские праздники на автобусе и пароме в Финляндию, Швецию и Данию из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм -  Копенгаген. Без ночных переездов по Скандинавии.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки", "Турку","Стокгольм", "Хельсингборг", "Копенгаген" },
        periodStart = new DateTimeOffset(2019, 5, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 18371.52,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/91390126-d157-412d-a2cf-cfd9ffd9ea2d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_91390126-d157-412d-a2cf-cfd9ffd9ea2d.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            }
            }
            },

                new Product
            {
        id = 42,
        title = "От Хельсинки до Таллина - на двух берегах",
        header = "Экскурсионный автобусно-паромный тур в Финляндию и Эстонию из Санкт-Петербурга по маршруту: Хельсинки - Таллин.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Порвоо","Хельсинки", "Таллин", "Раквере" },
        periodStart = new DateTimeOffset(2019, 4, 6, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 21156.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2f35dbe4-4b1c-4c06-908e-6bda32b35f8c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2f35dbe4-4b1c-4c06-908e-6bda32b35f8c.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c9b291bf-859a-4fca-a992-7fdc15028878.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c9b291bf-859a-4fca-a992-7fdc15028878.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c3d8a107-5eef-4d88-8966-c8fb1d71f72d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c3d8a107-5eef-4d88-8966-c8fb1d71f72d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3dbc10da-c338-4e1d-b646-47c9c03365a0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3dbc10da-c338-4e1d-b646-47c9c03365a0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/986ba070-c51c-49c2-bcbe-cc31ded0041d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_986ba070-c51c-49c2-bcbe-cc31ded0041d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4afb4692-cbf5-46d0-8692-1ecfb763a79d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4afb4692-cbf5-46d0-8692-1ecfb763a79d.jpg"
            }
            }
            },
            new Product
            {
        id = 43,
        title = "Сырный тур в Финляндию",
        header = "Автобусный тур  в Финляндию на 2 дня из Санкт-Петербурга по маршруту: Сиппола - Котка.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Сиппола", "Котка" },
        periodStart = new DateTimeOffset(2019, 4, 6, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 17100.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b4192db7-1de9-430c-9665-85617650704e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b4192db7-1de9-430c-9665-85617650704e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b4192db7-1de9-430c-9665-85617650704e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b4192db7-1de9-430c-9665-85617650704e.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ac0e9075-ec50-49ce-8091-642165d0f0e2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ac0e9075-ec50-49ce-8091-642165d0f0e2.jpg"
            }
            }
            },

                new Product
            {
        id = 44,
        title = "Рускеала - Сортавала, 1 день",
        header = "Однодневная экскурсия в Карелию из Санкт-Петербурга в 2019 году по маршруту: Саперное - Рускеала - Сортавала",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Саперное", "каньон Рускеала", "Сортавала" },
        periodStart = new DateTimeOffset(2019, 4, 27, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 27, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 2790.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbd9017a-fef9-4172-a860-37750fb47cba.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbd9017a-fef9-4172-a860-37750fb47cba.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/37fcaa16-d297-4b13-91f5-808868f6dea9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_37fcaa16-d297-4b13-91f5-808868f6dea9.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9873d4f1-46a0-4fbb-a9e9-3c8218a255eb.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9873d4f1-46a0-4fbb-a9e9-3c8218a255eb.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce2f8d2e-8abd-4475-902f-90472ac3bd47.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce2f8d2e-8abd-4475-902f-90472ac3bd47.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5d17e9c2-8109-4b4a-bd89-48c65adc46ca.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5d17e9c2-8109-4b4a-bd89-48c65adc46ca.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8d24b298-b99a-491c-aa35-00cbecd5e046.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8d24b298-b99a-491c-aa35-00cbecd5e046.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/319849a6-bf13-46c3-8009-c84309f128a2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_319849a6-bf13-46c3-8009-c84309f128a2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9f798143-41a4-422e-a3cb-63e35584805c.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9f798143-41a4-422e-a3cb-63e35584805c.jpeg"
            }
            }
            },

                    new Product
            {
        id = 45,
        title = "Путешествие на остров Готланд",
        header = "Автобусный экскурсионный тур в Эстонию и Швецию из Санкт-Петербурга по маршруту: Таллин - о. Готланд (г. Висбю) - Таллин - национальный парк Лахемаа - деревня капитанов Кясму.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Таллин","Висбю" },
        periodStart = new DateTimeOffset(2019, 7, 14, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 65196.00,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/511c356f-3527-4194-8bf0-432e48a3ccf4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_511c356f-3527-4194-8bf0-432e48a3ccf4.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            }
            }
            },

                new Product
            {
        id = 46,
        title = "Выборг, 1 день",
        header = "Однодневная экскурсия в Выборг из Санкт-Петербурга в 2019 году.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Выборг" },
        periodStart = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 1790.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ae50348b-f094-468c-925e-cccac788a158.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ae50348b-f094-468c-925e-cccac788a158.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/cd65bb04-3caa-4764-91fc-40d4415bd4f5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_cd65bb04-3caa-4764-91fc-40d4415bd4f5.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/13d0240f-dc38-4a1f-96a3-5c307326008a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_13d0240f-dc38-4a1f-96a3-5c307326008a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/10bccba8-58f0-4028-ba38-3cd142e1f0ac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_10bccba8-58f0-4028-ba38-3cd142e1f0ac.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ae50348b-f094-468c-925e-cccac788a158.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ae50348b-f094-468c-925e-cccac788a158.jpg"
            }
            }
            },

                    new Product
            {
        id = 47,
        title = "Рождествено - Любенск - Вечаша",
        header = "Однодневная экскурсия по Ленинградской и Псковской областям из Санкт-Петербурга в 2019 году по маршруту: Рождествено - Любенск - Вечаша.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Рождествено",  "Любенск", "Вечаша" },
        periodStart = new DateTimeOffset(2019, 4, 20, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 20, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 2390.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6473a71b-fafe-4ee4-95b7-1a22cdb6b610.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6473a71b-fafe-4ee4-95b7-1a22cdb6b610.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a8836377-efb0-4096-a3b2-1053cc785a68.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a8836377-efb0-4096-a3b2-1053cc785a68.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/49f8a46f-70f3-4b76-b174-c3b0d97202a5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_49f8a46f-70f3-4b76-b174-c3b0d97202a5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c316a4a2-2d3b-4064-ad1d-1c51c2cd3960.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c316a4a2-2d3b-4064-ad1d-1c51c2cd3960.jpg"
            }
            }
            },

                new Product
            {
        id = 48,
        title = "Сказочные приключения в Прибалтике",
        header = "Экскурсионный автобусный тур для детей и их родителей в Эстонию и Латвию из Санкт-Петербурга по маршруту: Таллин - Рига.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Таллин", "Рига" },
        periodStart = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 23814.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/db82563d-d07c-4587-8cde-1673ba037598.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_db82563d-d07c-4587-8cde-1673ba037598.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c8832f73-8d79-4f49-aad3-108c4a4c3330.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c8832f73-8d79-4f49-aad3-108c4a4c3330.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/95c1a6e1-c537-45ff-b5fa-f9afc965bcec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_95c1a6e1-c537-45ff-b5fa-f9afc965bcec.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/795bc43b-cfdd-4041-8b13-f411f3f41995.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_795bc43b-cfdd-4041-8b13-f411f3f41995.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/db82563d-d07c-4587-8cde-1673ba037598.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_db82563d-d07c-4587-8cde-1673ba037598.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/656acbe9-729d-4008-bb55-052ac028dbb6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_656acbe9-729d-4008-bb55-052ac028dbb6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb61302a-d30d-4c1f-abc1-bb5eeec706c5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e0579fe-5961-4154-9c33-43ea4294e5f7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f083d345-92ba-480b-845a-852923e2ff93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f083d345-92ba-480b-845a-852923e2ff93.jpg"
            }
            }
            },

                    new Product
            {
        id = 49,
        title = "По заповедным местам Псковского края",
        header = "Автобусный тур выходного дня по Псковской области из Санкт-Петербурга в 2019 году по маршруту: Псков – Изборск - Остров – Пушкинские Горы.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Псков","Изборск","Остров", "Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 7, 20, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 21, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 27520.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f2e830ed-56ee-4b4c-b3e6-5858a21298bf.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f2e830ed-56ee-4b4c-b3e6-5858a21298bf.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3840b88a-859d-4dbb-9882-43f885c9cad1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3840b88a-859d-4dbb-9882-43f885c9cad1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ee2d9e9b-eb1a-4f96-860e-62b625e47805.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/214ba396-c56a-41bf-aece-13cb369b8418.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_214ba396-c56a-41bf-aece-13cb369b8418.jpg"
            }
            }
            },

            new Product
            {
        id = 50,
        title = "Премиум Фьорды + Копенгаген (авиа), 7 дней",
        header = "Экскурсионный тур в Норвегию и Данию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Берген - Хардангерфьорд - Копенгаген.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Осло", "Согнефьорд", "Берген", "Хардангерфьорд", "Копенгаген" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 8, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 201372.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6ba77964-8048-4144-b614-16cd11842d5c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6ba77964-8048-4144-b614-16cd11842d5c.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            }
            }
            },

                new Product
            {
        id = 51,
        title = "Премиум Фьорды (авиа), 10 дней",
        header = "Экскурсионный тур в Норвегию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Эйдфьорд - Ставангер - Берген - Нордфьорд - Бриксдаль - Гейрангер - Олесунд.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Осло","Согнефьорд", "Эйдфьорд","Ставангер", "Берген", "Нордфьорд", "Ледник Бриксдаль", "Гейрангерфьорд", "Олесунн" },
        periodStart = new DateTimeOffset(2019, 7, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 170458.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fe4e6dd9-4465-4949-8028-62671450b55a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fe4e6dd9-4465-4949-8028-62671450b55a.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/15079637-85df-4a94-985d-7215df223195.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_15079637-85df-4a94-985d-7215df223195.jpg"
            }
            }
            },

                    new Product
            {
        id = 52,
        title = "Премиум Фьорды + Копенгаген (авиа), 11 дней",
        header = "Экскурсионный тур в Норвегию и Данию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Эйдфьорд - Ставангер - Берген - Нордфьорд - Бриксдаль - Гейрангер - Олесунд - Копенгаген.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Осло", "Согнефьорд", "Эйдфьорд", "Ставангер",  "Берген", "Нордфьорд", "Ледник Бриксдаль", "Гейрангерфьорд", "Олесунн","Копенгаген" },
        periodStart = new DateTimeOffset(2019, 7, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 363328.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8c3d2ef8-98b9-4782-83e6-2583c09d77be.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8c3d2ef8-98b9-4782-83e6-2583c09d77be.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/15079637-85df-4a94-985d-7215df223195.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_15079637-85df-4a94-985d-7215df223195.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg"
            }
            }
            },

                new Product
            {
        id = 53,
        title = "Премиум Фьорды (авиа), 6 дней",
        header = "Экскурсионный тур в Норвегию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Берген - Хардангерфьорд.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Осло", "Согнефьорд", "Берген","Хардангерфьорд" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 88464.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/15079637-85df-4a94-985d-7215df223195.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_15079637-85df-4a94-985d-7215df223195.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg"
            }
            }
            },

                    new Product
            {
        id = 54,
        title = "Премиум Фьорды (авиа), 8 дней",
        header = "Экскурсионный тур в Норвегию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Берген - Нордфьорд - Бриксдаль - Гейрангер - Олесунд.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Осло", "Согнефьорд", "Берген", "Нордфьорд", "Ледник Бриксдаль", "Гейрангерфьорд", "Олесунн" },
        periodStart = new DateTimeOffset(2019, 6, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 130226.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/1d8e95b9-131d-41a0-a02b-6013ad72692c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_1d8e95b9-131d-41a0-a02b-6013ad72692c.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/15079637-85df-4a94-985d-7215df223195.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_15079637-85df-4a94-985d-7215df223195.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b18296ea-da95-4a0c-aff5-8a994dbc5b09.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b18296ea-da95-4a0c-aff5-8a994dbc5b09.jpg"
            }
            }
            },

            new Product
            {
        id = 55,
        title = "Премиум Фьорды + Копенгаген (авиа), 9 дней",
        header = "Экскурсионный тур в Норвегию и Данию из Санкт-Петербурга по маршруту: Осло - Согнефьорд - Берген - Нордфьорд - Бриксдаль - Гейрангер - Олесунд - Копенгаген.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Осло", "Согнефьорд", "Берген","Нордфьорд",  "Ледник Бриксдаль","Гейрангерфьорд","Олесунн", "Копенгаген" },
        periodStart = new DateTimeOffset(2019, 6, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 259432.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/72fac0e9-2c22-48c3-9694-57f54e2f3a89.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_72fac0e9-2c22-48c3-9694-57f54e2f3a89.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/93d28453-9719-41c9-8d21-4ddffd956cc3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_93d28453-9719-41c9-8d21-4ddffd956cc3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e6cca597-1665-46b4-a52f-bbda441122ce.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e6cca597-1665-46b4-a52f-bbda441122ce.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3a7046fb-5b7a-41a9-b60a-a5d8aa20c3e1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/15079637-85df-4a94-985d-7215df223195.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_15079637-85df-4a94-985d-7215df223195.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_752e2302-f92e-4c1a-8ff5-037286d65ea6.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_acb471e0-1cc1-4917-b0ce-792fd651c32a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2a0dbbd0-e362-46ee-a5f8-4d658b3bd05d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b5dfb8f6-fcaf-4eb1-ab04-536233626d5c.jpg"
            }
            }
            },

                new Product
            {
        id = 56,
        title = "По берегам живописной Мсты",
        header = "Автобусный тур выходного дня в Новгородскую область из Санкт-Петербурга на 2019 год по маршруту: Любытино – Боровичи – Кончанское-Суворовское. С отдыхом на базе «Любытино-Хутор»",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Любытино", "Кончанское–Суворовское","Боровичи" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 14400.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/270dc9ab-e02b-4aa9-8ee2-b474d015572f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_270dc9ab-e02b-4aa9-8ee2-b474d015572f.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/07506712-4b7c-4176-b62b-329479a5d457.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_07506712-4b7c-4176-b62b-329479a5d457.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f9d11c38-094d-4a4a-87f4-a644d6e6181f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f9d11c38-094d-4a4a-87f4-a644d6e6181f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a136851b-34ef-4007-a322-67692530e461.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a136851b-34ef-4007-a322-67692530e461.jpg"
            }
            }
            },

                    new Product
            {
        id = 57,
        title = "Романтик бал в Пушкинских Горах: Весна! Любовь! Музыка!",
        header = "Автобусный тур в Пушкинские Горы из Санкт-Петербурга с 23 по 24 марта 2019 года с посещением Романтик бала.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Пушкинские Горы" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 29600.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5ef2f935-3aa0-4076-95c1-be732719c787.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5ef2f935-3aa0-4076-95c1-be732719c787.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5ef2f935-3aa0-4076-95c1-be732719c787.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5ef2f935-3aa0-4076-95c1-be732719c787.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ad3bc2fe-d969-4e68-963c-7f983eda1559.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0abaa546-0357-4fff-9d24-44b77fde50b0.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0abaa546-0357-4fff-9d24-44b77fde50b0.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7a347b88-d0bc-4437-8c0d-5998636af1e0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7d7e8579-6c84-4d61-8adb-f707de497668.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7d7e8579-6c84-4d61-8adb-f707de497668.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f190dcd3-b644-41af-9f86-5f898fd2c64f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f190dcd3-b644-41af-9f86-5f898fd2c64f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a4a9340c-2f1a-4071-955a-0c26088f19a3.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/626d19f2-e5dc-4210-84b2-95e38de1dd8d.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_626d19f2-e5dc-4210-84b2-95e38de1dd8d.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/20602ccc-c5dd-4082-a198-a68252a2d900.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_20602ccc-c5dd-4082-a198-a68252a2d900.JPG"
            }
            }
            },

    new Product
            {
        id = 58,
        title = "Круиз на пароме «Princess Anastasia» на майские праздники",
        header = "Круиз на пароме \"Принцесса Анастасия\" в Финляндию, Швецию, Эстонию и Латвию из Санкт-Петербурга на майские праздники. 28.04.2019  по маршрут: Таллин – Рига - Стокгольм – Хельсинки и 07.05.2019 по маршрут: Таллин – Стокгольм (2 дня) – Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Таллин", "Рига", "Стокгольм", "Хельсинки" },
        periodStart = new DateTimeOffset(2019, 4, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15384.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/63591fc3-5269-4cea-a8c2-0088e54775c3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_63591fc3-5269-4cea-a8c2-0088e54775c3.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/63591fc3-5269-4cea-a8c2-0088e54775c3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_63591fc3-5269-4cea-a8c2-0088e54775c3.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f608dfdf-3192-4346-8f78-e96db738a041.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f608dfdf-3192-4346-8f78-e96db738a041.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f06c96e-d378-439c-8c40-b5860186b9a2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f06c96e-d378-439c-8c40-b5860186b9a2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2d1bc222-7087-4cad-9bde-004fbcb57db3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2d1bc222-7087-4cad-9bde-004fbcb57db3.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d3e40a7d-a1bc-4fe3-a43b-4f7f52933050.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d3e40a7d-a1bc-4fe3-a43b-4f7f52933050.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/98bc11c8-112b-4a6f-98fc-8aad423706c3.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_98bc11c8-112b-4a6f-98fc-8aad423706c3.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f19cc2c-bee3-4925-a374-766bb80c65a7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f19cc2c-bee3-4925-a374-766bb80c65a7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e8775284-5f08-44b2-bd2b-22eaf6025e43.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e8775284-5f08-44b2-bd2b-22eaf6025e43.jpg"
            }
            }
            },

        new Product
            {
        id = 59,
        title = "Санкт-Петербург – Валаам – Санкт-Петербург, 3 дня",
        header = "Речной круиз на Валаам из Санкт-Петербурга",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Валаам" },
        periodStart = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 23800.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/db44bb17-446a-4409-9f22-cbcc353e4a31.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_db44bb17-446a-4409-9f22-cbcc353e4a31.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/234511b2-c9f9-4e33-a878-c8a3c78f7988.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_234511b2-c9f9-4e33-a878-c8a3c78f7988.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4528bdd7-ba94-48c1-98b9-23014e7a9e0b.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4528bdd7-ba94-48c1-98b9-23014e7a9e0b.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/880b18dc-69d7-4d4b-a99e-6535185d2281.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_880b18dc-69d7-4d4b-a99e-6535185d2281.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/49bb5735-1469-4557-bc35-49862795d57b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_49bb5735-1469-4557-bc35-49862795d57b.jpg"
            }
            }
            },

            new Product
            {
        id = 60,
        title = "Золотое кольцо, 5 дней (вариант 1)",
        header = "Тур по Золотому кольцу России из Санкт-Петербурга по маршруту: Сергиев Посад – Переславль-Залесский – Ростов Великий – Ярославль  - Кострома– Иваново – Боголюбово – Владимир – Суздаль  Большое Золотое кольцо.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Сергиев Посад","Переславль-Залесский", "Ростов Великий","Ярославль", "Кострома", "Иваново", "Суздаль", "Боголюбово", "Владимир" },
        periodStart = new DateTimeOffset(2019, 3, 26, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 35980.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/947e22ef-175f-4edb-b1c2-9c8ac41ee64e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_947e22ef-175f-4edb-b1c2-9c8ac41ee64e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/2435989b-651c-41a5-aa9b-1b6cbf6fdd93.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_2435989b-651c-41a5-aa9b-1b6cbf6fdd93.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5d056cfb-e0cc-4089-9d46-dd5b640a581d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5d056cfb-e0cc-4089-9d46-dd5b640a581d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c967bf00-324d-4d92-89e1-d8b042416293.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c967bf00-324d-4d92-89e1-d8b042416293.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/31c4883e-22d7-4cf9-8881-3d0aed9ac0ad.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_31c4883e-22d7-4cf9-8881-3d0aed9ac0ad.jpg"
            }
            }
            },

                new Product
            {
        id = 61,
        title = "Жемчужины Европы, 10 дней",
        header = "Экскурсионный тур во Францию без ночных переездов через Финляндию, Швецию, Германию, Голландию и Бельгию из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм – Росток или Засниц - Амстердам -  Париж (4 дня) - Брюссель.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки","Турку", "Стокгольм", "Треллеборг", "Росток", "Засниц", "Амстердам",  "Лилль",  "Париж", "Диснейленд Париж", "Версаль","Брюссель" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 29088.24,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a87550bc-d781-4561-9969-5c1fce2da750.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a87550bc-d781-4561-9969-5c1fce2da750.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"
            }
            }
            },

                    new Product
            {
        id = 62,
        title = "Два дня в Москве",
        header = "Экскурсионный тур в Москву из Санкт-Петербурга на весенние каникулы 2019 года.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Москва"},
        periodStart = new DateTimeOffset(2019, 3, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c93527e6-e0ee-4fa4-90b4-33d884e0e39f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c93527e6-e0ee-4fa4-90b4-33d884e0e39f.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/69a395da-5a09-455c-adb9-4485b88ec48a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_69a395da-5a09-455c-adb9-4485b88ec48a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg"
            }
            }
            },

                        new Product
            {
        id = 63,
        title = "3 дня на Соловецких островах (вариант 1)",
        header = "Трехдневный экскурсионный тур на Соловецкие острова. Экскурсия на Соловки через Петрозаводск и Беломорск.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Петрозаводск", "Беломорск", "Соловецкие острова" },
        periodStart = new DateTimeOffset(2019, 6, 14, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 18, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 31000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c2459342-ae12-4266-89a9-54603b2e44c2.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c2459342-ae12-4266-89a9-54603b2e44c2.jpeg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f7d669a8-e2ad-4b3e-be64-f61ce868e41d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f7d669a8-e2ad-4b3e-be64-f61ce868e41d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f7500df-0092-4ab1-9f2a-7d27aa3ba958.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f7500df-0092-4ab1-9f2a-7d27aa3ba958.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/85b3672d-d003-4ac5-b099-d44e7c6b491c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_85b3672d-d003-4ac5-b099-d44e7c6b491c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74aa1f78-0faf-4580-b94b-99390caae778.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74aa1f78-0faf-4580-b94b-99390caae778.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/96d68336-de85-40e3-acf3-1328801a2ec8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_96d68336-de85-40e3-acf3-1328801a2ec8.jpg"
            }
            }
            },

                new Product
            {
        id = 64,
        title = "В Париж с комфортом",
        header = "Экскурсионный автобусно-паромный тур во Францию и города Европы по маршруту: Хельсинки - Турку - Стокгольм - Копенгаген - Амстердам - Париж - Гент - Брюгге - Брюссель - Любек.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки", "Турку", "Стокгольм", "Копенгаген", "Амстердам", "Париж", "Диснейленд Париж","Гент",  "Брюгге", "Брюссель", "Любек" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 4900.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d09d960f-b1b4-43f3-a584-f534d2bb478b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d09d960f-b1b4-43f3-a584-f534d2bb478b.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            }
            }
            },

                    new Product
            {
        id = 65,
        title = "Золотое кольцо, 4 дня (вариант 2)",
        header = "Тур по Золотому кольцу России из Санкт-Петербурга по маршруту: Переславль-Залесский - Ростов Великий - Ярославль - Кострома - Плёс - Иваново - Юрьев-Польский - Владимир - Суздаль. Малое Золотое кольцо.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Москва", "Переславль-Залесский", "Ростов Великий", "Ярославль", "Кострома","Плёс",  "Иваново",  "Юрьев-Польский", "Владимир", "Суздаль" },
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 53400.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fae0c4f4-f545-4e5b-8794-c0deb8042478.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fae0c4f4-f545-4e5b-8794-c0deb8042478.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/69a395da-5a09-455c-adb9-4485b88ec48a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_69a395da-5a09-455c-adb9-4485b88ec48a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce8a3a58-dd56-4059-988f-e381cbeb92b6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce8a3a58-dd56-4059-988f-e381cbeb92b6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/23dfa254-a27c-4510-a404-9a1d1d0666a8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_23dfa254-a27c-4510-a404-9a1d1d0666a8.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/391a3bbb-f573-482d-8c23-fbf657e1a3dc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_391a3bbb-f573-482d-8c23-fbf657e1a3dc.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/396101e9-9cfb-4531-8e24-d44b690c5393.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_396101e9-9cfb-4531-8e24-d44b690c5393.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b772c872-bd78-4c1b-b72e-499f18a09bc0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b772c872-bd78-4c1b-b72e-499f18a09bc0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5a9f0275-86db-4a55-ac24-2ebb8655b26d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5a9f0275-86db-4a55-ac24-2ebb8655b26d.jpg"
            }
            }
            },

          new Product
            {
        id = 66,
        title = "Путь викинга (вариант 1)",
        header = "Экскурсионный тур в Норвегию из Санкт-Петербурга   с одним  ночным  переездом по маршруту:  Хельсинки – Турку (паром Tallink Silja ) - Стокгольм - Согнефьорд – Флом – Осло.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Хельсинки", "Турку","Стокгольм", "Согнефьорд", "Флом",  "Осло" },
        periodStart = new DateTimeOffset(2019, 5, 12, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15692.34,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7104bc9b-dab5-4633-bf88-4199b7f36837.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7104bc9b-dab5-4633-bf88-4199b7f36837.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"
            }
            }
            },

              new Product
            {
        id = 67,
        title = "Автобусный тур по Золотому кольцу (вариант 1)",
        header = "Автобусный тур по Золотому кольцу из Санкт-Петербурга летом 2019 года по маршруту: С-Петербург – Москва – Владимир – Боголюбово – Суздаль – Иваново – Кострома – Ярославль – Ростов Великий – Переславль Залесский –  Сергиев Посад – Москва – С-Петербург",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Владимир","Боголюбово", "Суздаль", "Плёс", "Иваново", "Кострома",  "Ярославль", "Ростов Великий", "Переславль-Залесский", "Сергиев Посад" },
        periodStart = new DateTimeOffset(2019, 6, 10, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 43380.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fe95bb11-addd-4fda-b2ff-62702cdfd341.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fe95bb11-addd-4fda-b2ff-62702cdfd341.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/95df4db4-8af1-42f1-a68a-10db04f17701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_95df4db4-8af1-42f1-a68a-10db04f17701.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/045eeac9-a9ec-45b3-861b-d478b7cbe872.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_045eeac9-a9ec-45b3-861b-d478b7cbe872.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7fb1877c-5fbb-4ea3-a4cd-54fd4cbc4079.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7fb1877c-5fbb-4ea3-a4cd-54fd4cbc4079.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/98b3ef81-ff54-47d4-a0de-926721d067b9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_98b3ef81-ff54-47d4-a0de-926721d067b9.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45c1e4f-3086-4f7d-9794-bd5dd93dabfc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45c1e4f-3086-4f7d-9794-bd5dd93dabfc.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a215c495-84e4-416d-b6ee-e6ec16e9b290.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a215c495-84e4-416d-b6ee-e6ec16e9b290.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/02243764-84fc-4fc9-8141-16b2a52ce9df.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_02243764-84fc-4fc9-8141-16b2a52ce9df.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6ce9c474-4243-4eb3-b36a-80cf937eb2e2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6ce9c474-4243-4eb3-b36a-80cf937eb2e2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bde0e8f-35ec-497f-b7f5-c19ec218ea4f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bde0e8f-35ec-497f-b7f5-c19ec218ea4f.jpg"
            }
            }
            },

                  new Product
            {
        id = 68,
        title = "Франция - Италия на автобусе, 13 дней",
        header = "Экскурсионный автобусный тур по Европе  без ночных переездов  из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм - Треллеборг - Росток - Амстердам - Париж - Версаль - Диснейленд Париж - Ницца - Монте-Карло - Пиза - Флоренция - Рим - Венеция - Дрезден.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки", "Турку", "Стокгольм", "Треллеборг", "Росток", "Амстердам", "Париж", "Версаль",  "Диснейленд Париж", "Ницца", "Монте-Карло", "Пиза", "Флоренция", "Рим", "Венеция", "Дрезден" },
        periodStart = new DateTimeOffset(2019, 4, 27, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 9, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 48148.69,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0ec389fb-6987-4e37-9ad5-c73d0dc6e642.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0ec389fb-6987-4e37-9ad5-c73d0dc6e642.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            }
            }
            },

                      new Product
            {
        id = 69,
        title = "Жемчужины Европы, 9 дней",
        header = "Экскурсионный тур во Францию без ночных переездов из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм -  Амстердам - Париж - Брюссель -  Стокгольм - Турку.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Хельсинки", "Турку","Стокгольм", "Треллеборг", "Гамбург", "Любек",  "Росток", "Засниц", "Париж", "Диснейленд Париж", "Амстердам", "Брюссель" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 29853.72,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d2e6c003-2e31-49ad-9341-2018cec40d5f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d2e6c003-2e31-49ad-9341-2018cec40d5f.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            }
            }
            },

                          new Product
            {
        id = 70,
        title = "Прага - Вена - Дрезден",
        header = "Еженедельный авиатур в Чехию  из Санкт-Петербурга по маршруту: Прага -  Вена - Дрезден. ",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Прага", "Вена", "Дрезден" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 68254.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/48a652b1-f425-42b1-8698-13dd3684a3b1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_48a652b1-f425-42b1-8698-13dd3684a3b1.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f60c870d-87ea-49b3-ac27-d962a502e98d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f60c870d-87ea-49b3-ac27-d962a502e98d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a4df77f0-583d-4ba2-a7df-a5cd0c371091.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a4df77f0-583d-4ba2-a7df-a5cd0c371091.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c1f22a49-c17d-44c3-854a-d44f8a2d5b30.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c1f22a49-c17d-44c3-854a-d44f8a2d5b30.jpg"
            }
            }
            },

                new Product
            {
        id = 71,
        title = "Швейцария - Италия",
        header = "Экскурсионный автобусный тур в Швейцарию и Италию из Санкт-Петербурга без ночных автобусных переездов по маршруту: Хельсинки - Стокгольм - Мюнхен - Цюрих - Люцерн - Милан - Флоренция - Рим - Неаполь - Помпеи - Венеция - Дрезден.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Турку", "Хельсинки",  "Стокгольм", "Треллеборг", "Мюнхен", "Цюрих", "Люцерн", "Милан", "Флоренция", "Рим", "Венеция", "Дрезден" },
        periodStart = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 47077.02,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b4a9c652-e0f8-402b-9122-bdd3a25cdfee.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b4a9c652-e0f8-402b-9122-bdd3a25cdfee.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f64a937b-d906-4fa9-9cf8-9fc89f37367a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f64a937b-d906-4fa9-9cf8-9fc89f37367a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6c3caa34-c484-4ac8-a466-5ce8958434a1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6c3caa34-c484-4ac8-a466-5ce8958434a1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4e7875d0-4ca6-4404-b7a9-c5140a28c3ab.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4e7875d0-4ca6-4404-b7a9-c5140a28c3ab.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/230ecdbd-fc30-4613-a285-fc0ca1b4ea3f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_230ecdbd-fc30-4613-a285-fc0ca1b4ea3f.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5aae86e5-b15e-4f1d-9079-25898bb28483.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5aae86e5-b15e-4f1d-9079-25898bb28483.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/57b43cf3-33cf-4bc7-84d1-17d49fbcb0b6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_57b43cf3-33cf-4bc7-84d1-17d49fbcb0b6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0dc2c40b-f26c-4c29-9f13-648e2ec136d8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0dc2c40b-f26c-4c29-9f13-648e2ec136d8.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"
            }
            }
            },

                    new Product
            {
        id = 72,
        title = "Три дня в Москве",
        header = "Экскурсионный тур в Москву из Санкт-Петербурга.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Москва"},
        periodStart = new DateTimeOffset(2019, 3, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 19800.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5a9f0275-86db-4a55-ac24-2ebb8655b26d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5a9f0275-86db-4a55-ac24-2ebb8655b26d.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/69a395da-5a09-455c-adb9-4485b88ec48a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_69a395da-5a09-455c-adb9-4485b88ec48a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e9267499-cb4c-4b4e-a4e5-6eff81adcfc4.jpeg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f7528199-e1b5-4d5c-91b1-309ebfc93749.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce8a3a58-dd56-4059-988f-e381cbeb92b6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce8a3a58-dd56-4059-988f-e381cbeb92b6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/23dfa254-a27c-4510-a404-9a1d1d0666a8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_23dfa254-a27c-4510-a404-9a1d1d0666a8.jpg"
            }
            }
            },
                        new Product
            {
        id = 73,
        title = "Монастыри Севера, 2 дня (вариант 1)",
        header = "Экскурсионный тур в Вологду из Санкт-Петербурга по маршруту: Вологда - Ферапонтово - Кириллов.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Вологда", "Кириллов", "Ферапонтово" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15334.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/66e2ff03-effa-4234-92f7-dd283b2ada0f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_66e2ff03-effa-4234-92f7-dd283b2ada0f.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/633136d1-25b5-45fe-8172-1c379ea5c422.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_633136d1-25b5-45fe-8172-1c379ea5c422.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/af655b7d-bd00-48c4-928e-7568a884425a.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_af655b7d-bd00-48c4-928e-7568a884425a.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/07726df5-8bba-4061-82e6-6fc261311b83.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_07726df5-8bba-4061-82e6-6fc261311b83.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce1e6b48-5495-48f4-9095-276f8c8d1435.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce1e6b48-5495-48f4-9095-276f8c8d1435.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d3f7060c-4ded-4779-b153-bf5b6890e821.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d3f7060c-4ded-4779-b153-bf5b6890e821.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6a5cd018-dc13-47a4-8f32-67e199174fdd.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6a5cd018-dc13-47a4-8f32-67e199174fdd.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fe90a7f8-9b74-42c2-96cd-3bbfebe40568.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fe90a7f8-9b74-42c2-96cd-3bbfebe40568.JPG"
            }
            }
            },
         
            new Product
            {
        id = 74,
        title = "Жемчужины Европы, 9 дней (вариант бюджет)",
        header = "Экскурсионный экономичный тур на  пароме и автобусе  во Францию из Санкт-Петербурга  по маршруту: Хельсинки - Турку - Стокгольм - Амстердам - Париж - Брюссель-Гамбург. ( 2 ночных переезда)",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки", "Турку", "Стокгольм", "Треллеборг",  "Росток", "Засниц", "Амстердам", "Париж", "Диснейленд Париж", "Версаль", "Брюссель" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 22581.66,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/baed6bef-c72a-4876-859f-8c328c1e37cf.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_baed6bef-c72a-4876-859f-8c328c1e37cf.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            }
            }
            },

                new Product
            {
        id = 75,
        title = "Автобусный тур в Калининград «Три дня в Восточной Пруссии», 5 дней",
        header = "Автобусный экскурсионный тур в Калининград из Санкт-Петербурга по маршруту: Рига - Тильзит - Истенбург - Георгенбург - Кенигсберг - Раушен - Куршская коса - Гора Ведьм - Шауляй - Гора Крестов - Псков.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Рига", "Советск", "Черняховск", "Калининград", "Светлогорск","Куршская коса", "Клайпеда", "Шяуляй", "Псков" },
        periodStart = new DateTimeOffset(2019, 5, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 35300.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/56510ca9-9b7c-4d9b-a923-a08d53fb4222.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_56510ca9-9b7c-4d9b-a923-a08d53fb4222.jpeg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9d3067c1-0832-4816-b14c-6523b5dd9582.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9d3067c1-0832-4816-b14c-6523b5dd9582.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4c18361-9a6c-4025-9325-8c911344e720.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4c18361-9a6c-4025-9325-8c911344e720.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/901903f1-7db0-41ca-be5f-26e582451897.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_901903f1-7db0-41ca-be5f-26e582451897.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6f2755a5-fc10-4879-bd7c-67eb2a8f8993.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/539dd28c-df74-4c93-8d66-e5f384994888.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_539dd28c-df74-4c93-8d66-e5f384994888.jpg"
            }
            }
            },

                    new Product
            {
        id = 76,
        title = "Северная корона, 5 дней",
        header = "Экскурсионный тур на пароме и автобусе в Данию и Швецию из Санкт-Петербурга по маршруту: Санкт-Петербург - Хельсинки - Стокгольм - Копенгаген - Турку.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Стокгольм", "Копенгаген", "Хельсинки", "Турку" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 27, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 12630.42,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6a0d876b-e3f4-4a8a-b795-3744b15a3d30.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6a0d876b-e3f4-4a8a-b795-3744b15a3d30.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0cb1c8d0-ced6-4a29-8be2-f3a576eadec7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0cb1c8d0-ced6-4a29-8be2-f3a576eadec7.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5ebb0d77-5988-4a93-87f8-19d8dcd65132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5ebb0d77-5988-4a93-87f8-19d8dcd65132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/89fd871d-5c94-4876-80f9-0f081146882d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_89fd871d-5c94-4876-80f9-0f081146882d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c5bb9341-07a5-4d26-b40f-08aff2ebfd68.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c5bb9341-07a5-4d26-b40f-08aff2ebfd68.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/97978672-75f3-45bc-80a1-b79c180e1413.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_97978672-75f3-45bc-80a1-b79c180e1413.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3093f096-3626-475c-bf0f-7c392c275f6c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3093f096-3626-475c-bf0f-7c392c275f6c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7046a298-0f81-4647-9340-7c23be66ce63.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7046a298-0f81-4647-9340-7c23be66ce63.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c84a130c-1f56-4fbd-84c7-552f6ff24e3d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c84a130c-1f56-4fbd-84c7-552f6ff24e3d.jpg"
            }
            }
            },

                        new Product
            {
        id = 77,
        title = "Незабываемые фьорды",
        header = "Экскурсионный тур в Норвегию из Санкт-Петербурга  по маршруту: Хельсинки -  Стокгольм - Гейло -  Хардангерфьорд – Берген -  Согнефьорд – Флом – Осло – Стокгольм (паром Tallink Silja) – Турку – Хельсинки - СПб",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки", "Стокгольм", "Берген", "Хардангерфьорд", "Согнефьорд", "Флом", "Осло", "Турку" },
        periodStart = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 10, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 26026.32,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0b6ac2c7-57e2-44c2-8027-80a3bfeb4bab.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0b6ac2c7-57e2-44c2-8027-80a3bfeb4bab.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            }
            }
            },

            new Product
            {
        id = 78,
        title = "В гости к Гадюке Васильевне",
        header = "Экскурсионный тур в Тверь из Санкт-Петербурга по маршруту: Кимры – Гадово – Тверь – Старица – Берново – Домотканово – Торжок – Прутня.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Кимры","Гадово","Тверь", "Старица",  "Берново",  "Домотканово","Торжок", "Прутня"},
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 26314.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/18793225-cc71-4935-938c-d744419c62b1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_18793225-cc71-4935-938c-d744419c62b1.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c6de69de-d2e9-4b9e-a0de-b8b1dc684f6d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c6de69de-d2e9-4b9e-a0de-b8b1dc684f6d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/51933351-49c2-45e1-a123-16e17fecc693.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_51933351-49c2-45e1-a123-16e17fecc693.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/aed16c9f-0446-406b-a165-81f18a6f40e9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_aed16c9f-0446-406b-a165-81f18a6f40e9.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b4504877-012a-42d5-bb6d-1e38c5ef3b2d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b4504877-012a-42d5-bb6d-1e38c5ef3b2d.jpg"
            }
            }
            },

            new Product
            {
        id = 79,
        title = "В край северных чудес Карелии",
        header = "Автобусный экскурсионный тур в Карелию из Санкт-Петербурга: Свято-Троицкий Александра Свирского мужской монастырь - Карьяла Парк - водопад Кивач - Марциальные воды - гора Сампо - Петрозаводск.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Свято-Троицкий Александра Свирского мужской монастырь", "Кивач",  "Марциальные воды", "Гора Сампо", "Петрозаводск" },
        periodStart = new DateTimeOffset(2019, 5, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 11314.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5044cfb4-67b8-4ecc-9b6c-8b094c7107b6.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5044cfb4-67b8-4ecc-9b6c-8b094c7107b6.JPG"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c98da8dc-eea7-4dcf-b7d5-b1203a16913d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c98da8dc-eea7-4dcf-b7d5-b1203a16913d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/60dd2081-456a-4404-8d44-10a16fb73a4a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_60dd2081-456a-4404-8d44-10a16fb73a4a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3162f8e3-f48f-4726-b32c-3da9d010b2f6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3162f8e3-f48f-4726-b32c-3da9d010b2f6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/1bb001c3-51ee-4173-86ee-912c6b83cb55.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_1bb001c3-51ee-4173-86ee-912c6b83cb55.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f39b3677-f106-4070-adff-32a94de8c543.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f39b3677-f106-4070-adff-32a94de8c543.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b9757eab-85b0-4b2f-b4c7-424f799973b2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b9757eab-85b0-4b2f-b4c7-424f799973b2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/00a04c2a-00b7-4a50-a93a-207a828243fc.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_00a04c2a-00b7-4a50-a93a-207a828243fc.jpg"
            }
            }
            },

                new Product
            {
        id = 80,
        title = "В сердце карельского края",
        header = "Автобусный экскурсионный тур в Карелию из Санкт-Петербурга: Приозерск - «Гора Филина» - Сортавала - Рускеала - Зоогринпарк.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Приозерск", "Гора Филина", "Сортавала", "каньон Рускеала", "Зоогринпарк"},
        periodStart = new DateTimeOffset(2019, 5, 2, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 3, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 11820.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/92d89e3d-f9b0-4418-81a2-e2d36eb16146.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_92d89e3d-f9b0-4418-81a2-e2d36eb16146.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eab62ff0-8975-4fd8-9861-62be476255bd.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eab62ff0-8975-4fd8-9861-62be476255bd.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dc4b5015-b15e-4eff-aec1-e63bfc753629.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dc4b5015-b15e-4eff-aec1-e63bfc753629.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a28b02bb-2fb9-47b5-934f-3d1e6c523638.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a28b02bb-2fb9-47b5-934f-3d1e6c523638.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/48d7871a-d85f-437b-8e50-ffdfb59821d4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_48d7871a-d85f-437b-8e50-ffdfb59821d4.jpg"
            }
            }
            },

                    new Product
            {
        id = 81,
        title = "Санкт-Петербург – Мандроги – Валаам – Санкт-Петербург, 4 дня",
        header = "Речной круиз из Санкт-Петербурга по маршруту: Санкт-Петербург, Мандроги, Валаам",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Мандроги", "Валаам" },
        periodStart = new DateTimeOffset(2019, 7, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 7, 8, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 73960.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/54543b2d-f363-4bfa-b58c-2306bc7da387.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_54543b2d-f363-4bfa-b58c-2306bc7da387.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c54687d3-b994-4503-aacc-1e7d1508cc60.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c54687d3-b994-4503-aacc-1e7d1508cc60.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/638a8026-0895-47ec-81e2-ffcd1827a014.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_638a8026-0895-47ec-81e2-ffcd1827a014.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b55bc00a-68cd-41bb-b7e1-37e6df478d5e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b55bc00a-68cd-41bb-b7e1-37e6df478d5e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/079a9bf8-3904-4498-b79e-bc5b4a660285.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_079a9bf8-3904-4498-b79e-bc5b4a660285.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dadf9f08-139a-4ef8-b5e0-772c680bf601.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dadf9f08-139a-4ef8-b5e0-772c680bf601.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e3254581-5d9c-40a5-be28-aa38196dc1f1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e3254581-5d9c-40a5-be28-aa38196dc1f1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/234511b2-c9f9-4e33-a878-c8a3c78f7988.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_234511b2-c9f9-4e33-a878-c8a3c78f7988.JPG"
            }
            }
            },

                        new Product
            {
        id = 82,
        title = "Прага для всех",
        header = "Экскурсионный комфортный  автобусный тур в Прагу  из Санкт-Петербурга без ночных автобусных переездов по маршруту: Санкт-Петербург – Каунас – Прага - Карловы Вары - Кутна Гора - Чешский Штенберг - Дрезден - Вроцлав - Вильнюс.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Каунас", "Прага", "Дрезден", "Карловы Вары", "Кутна Гора", "Вроцлав", "Вильнюс" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 51100.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f60c870d-87ea-49b3-ac27-d962a502e98d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f60c870d-87ea-49b3-ac27-d962a502e98d.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5c8b6e59-ff3c-4a79-a6cf-f35bd8295c15.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5c8b6e59-ff3c-4a79-a6cf-f35bd8295c15.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/49304026-a9fb-4c2d-b286-f169cc7ea085.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_49304026-a9fb-4c2d-b286-f169cc7ea085.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/67e7bed2-f095-43c1-ac63-35341a156bea.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_67e7bed2-f095-43c1-ac63-35341a156bea.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg"
            }
            }
            },

                new Product
            {
        id = 83,
        title = "Атлантическая дорога: из сердца Норвегии во власть фьордов",
        header = "Экскурсионный тур в Финляндию, Швецию и Норвегию из Санкт-Петербурга по маршруту: Вааса - Умео - Трондхейм - Олессун - Гейрангерфьорд - Карлстад - Стокгольм - Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Вааса", "Умео", "Трондхейм", "Мольде", "Олесунн", "Гейрангерфьорд", "Карлстад", "Стокгольм", "Хельсинки" },
        periodStart = new DateTimeOffset(2019, 5, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 57028.26,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/81f8a483-bb50-43f2-84a2-3aec7a01f1a1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_81f8a483-bb50-43f2-84a2-3aec7a01f1a1.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/81f8a483-bb50-43f2-84a2-3aec7a01f1a1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_81f8a483-bb50-43f2-84a2-3aec7a01f1a1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0cb1c8d0-ced6-4a29-8be2-f3a576eadec7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0cb1c8d0-ced6-4a29-8be2-f3a576eadec7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f28f4bc7-0053-4890-9673-8511eb2bd3b5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5ebb0d77-5988-4a93-87f8-19d8dcd65132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5ebb0d77-5988-4a93-87f8-19d8dcd65132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/89fd871d-5c94-4876-80f9-0f081146882d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_89fd871d-5c94-4876-80f9-0f081146882d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c5bb9341-07a5-4d26-b40f-08aff2ebfd68.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c5bb9341-07a5-4d26-b40f-08aff2ebfd68.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/97978672-75f3-45bc-80a1-b79c180e1413.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_97978672-75f3-45bc-80a1-b79c180e1413.jpg"
            }
            }
            },

                    new Product
            {
        id = 84,
        title = "Альпийская прогулка",
        header = "Экскурсионный тур на автобусе и пароме в Германию и Швейцарию  из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм - Треллеборг - Нюрнберг - Ваттенс - Рейнский водопад  - Цюрих - Люцерн - Мейринген - Интерлакен - Балленьерг- Берн - Женева - Люксембург - Бремен - Любек",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Порвоо", "Турку", "Стокгольм",  "Треллеборг", "Росток","Нюрнберг",  "Ваттенс", "Цюрих",  "Люцерн", "Мейринген",  "Балленберг", "Интерлакен", "Берн", "Женева", "Люксембург сити", "Любек" },
        periodStart = new DateTimeOffset(2019, 5, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 4, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 45163.32,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/395b7b93-cf63-456e-baf0-a945ce700592.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_395b7b93-cf63-456e-baf0-a945ce700592.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c9b291bf-859a-4fca-a992-7fdc15028878.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c9b291bf-859a-4fca-a992-7fdc15028878.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_adfe4461-af93-46a8-aff9-c5fdddb16bac.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c3d8a107-5eef-4d88-8966-c8fb1d71f72d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c3d8a107-5eef-4d88-8966-c8fb1d71f72d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3dbc10da-c338-4e1d-b646-47c9c03365a0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3dbc10da-c338-4e1d-b646-47c9c03365a0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/986ba070-c51c-49c2-bcbe-cc31ded0041d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_986ba070-c51c-49c2-bcbe-cc31ded0041d.jpg"
            }
            }
            },


                    new Product
            {
        id = 85,
        title = "Белоруссия. Замки, 2 дня (вариант 2)",
        header = "Экскурсионный тур в Белоруссию из Санкт-Петербурга на 2 дня по маршруту: Мир – Несвиж. Проживание в Мире.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Мир", "Несвиж" },
        periodStart = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 31, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 19000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e7417347-83dc-4634-8f20-94d876af17b1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e7417347-83dc-4634-8f20-94d876af17b1.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e7417347-83dc-4634-8f20-94d876af17b1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e7417347-83dc-4634-8f20-94d876af17b1.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9b8f50fd-5b04-49f5-9352-f9349499e8d2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9b8f50fd-5b04-49f5-9352-f9349499e8d2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/55ce9ad7-9d4d-40b9-9c21-72eb79b0324c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_55ce9ad7-9d4d-40b9-9c21-72eb79b0324c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/819f172e-cc54-4115-8d69-c75d7744a2a2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_819f172e-cc54-4115-8d69-c75d7744a2a2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74bd1f30-592d-4812-b92e-be8053ee69aa.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74bd1f30-592d-4812-b92e-be8053ee69aa.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/83476c71-7e0d-43d2-b553-203861e6e901.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_83476c71-7e0d-43d2-b553-203861e6e901.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/37ffa8ae-e17f-4d66-ab5f-686100e86f63.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_37ffa8ae-e17f-4d66-ab5f-686100e86f63.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c3feb0be-421a-4499-aaf6-8bd50d29c649.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c3feb0be-421a-4499-aaf6-8bd50d29c649.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ef9da259-6f88-4632-834d-032f228b4d8f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ef9da259-6f88-4632-834d-032f228b4d8f.jpg"
            }
            }
            },


                        new Product
            {
        id = 86,
        title = "Море и горы: Скандинавия + Эльзас + Каталония + Швейцария",
        header = "Экскурсионный тур по Европе с отдыхом в Испании на средиземном море по маршруту без ночных переездов: Санкт - Петербург – Порвоо – Турку - Стокгольм – Аахен - Люксмебург – Страсбург – Риквир - Леон - Барселона - Коста Брава –Женева – Монтрё – Веве – Люцерн – Цюрих – Бамберг - Стокгольм - Хельсинки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Котка", "Турку", "Стокгольм", "Копенгаген", "Кёльн", "Люксембург сити","Страсбург","Риквир", "Лион", "Барселона", "Жирона", "Фигерас", "Коста-Брава", "Женева",  "Монтрё","Люцерн", "Росток", "Мальме" },
        periodStart = new DateTimeOffset(2019, 7, 20, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 8, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 128340.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e4a07c80-cd2a-4d23-a996-64a095df3535.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e4a07c80-cd2a-4d23-a996-64a095df3535.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ac0e9075-ec50-49ce-8091-642165d0f0e2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ac0e9075-ec50-49ce-8091-642165d0f0e2.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f64a937b-d906-4fa9-9cf8-9fc89f37367a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f64a937b-d906-4fa9-9cf8-9fc89f37367a.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/6c3caa34-c484-4ac8-a466-5ce8958434a1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_6c3caa34-c484-4ac8-a466-5ce8958434a1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4e7875d0-4ca6-4404-b7a9-c5140a28c3ab.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4e7875d0-4ca6-4404-b7a9-c5140a28c3ab.jpg"
            }
            }
            },

                new Product
            {
        id = 87,
        title = "Скандинавская Сага, 6 дней",
        header = "Экскурсионный тур на пароме и автобусе в Данию, Швецию и Норвегию из Санкт-Петербурга по маршруту: Турку - Стокгольм -  Осло - Копенгаген - Стокгольм.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Хельсинки", "Турку", "Стокгольм",  "Осло", "Копенгаген"},
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 28, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 16840.56,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/95c96520-3186-464c-941e-bf55545b7296.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_95c96520-3186-464c-941e-bf55545b7296.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            }
            }
            },

                    new Product
            {
        id = 88,
        title = "Пражский экспресс",
        header = "Автобусный экскурсионный тур в Прагу  из Санкт-Петербурга с 1 ночным переездом по маршруту: Рига-Варшава-Прага-Вильнюс.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Рига", "Варшава", "Прага", "Тракай", "Вильнюс" },
        periodStart = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 30, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 39800.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a888b14d-a28c-4f62-b679-9ad4503dfd9e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dbca03f6-8823-446f-b1e6-e36e29a8d3bb.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9d3067c1-0832-4816-b14c-6523b5dd9582.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9d3067c1-0832-4816-b14c-6523b5dd9582.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3bfba707-34e5-4acd-a882-d7e3a2480caf.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f4c18361-9a6c-4025-9325-8c911344e720.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f4c18361-9a6c-4025-9325-8c911344e720.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ddc4395e-99e8-48b5-a86f-2605e3d8fb45.JPG"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/901903f1-7db0-41ca-be5f-26e582451897.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_901903f1-7db0-41ca-be5f-26e582451897.JPG"
            }
            }
            },

                new Product
            {
        id = 89,
        title = "Купеческий Нижний",
        header = "Экскурсионный тур в Нижний Новгород из Санкт-Петербурга по маршруту: Нижний Новгород.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {  "Нижний Новгород"},
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 9900.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d1f821f0-c13b-41de-b99a-00368aaec540.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d1f821f0-c13b-41de-b99a-00368aaec540.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d1f821f0-c13b-41de-b99a-00368aaec540.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d1f821f0-c13b-41de-b99a-00368aaec540.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/32b01fdf-dbbf-43f7-b596-64719f9d7eff.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_32b01fdf-dbbf-43f7-b596-64719f9d7eff.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/09d46c74-dbcc-480b-8f52-372766b2dc89.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_09d46c74-dbcc-480b-8f52-372766b2dc89.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/1110a6b8-b0c7-444a-9fa9-f63ba3d2cc47.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_1110a6b8-b0c7-444a-9fa9-f63ba3d2cc47.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e061337-0b84-4d66-8926-73ec4166a7c1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e061337-0b84-4d66-8926-73ec4166a7c1.jpg"
            }
            }
            },


                    new Product
            {
        id = 90,
        title = "Крымская кругосветка, 6 дней (вариант 1)",
        header = "Экскурсионный тур в Крым из Санкт-Петербурга по маршруту: Симферополь - Бахчисарай - Севастополь - Балаклава - Мисхор - Гаспра - Никита - Алушта - Судак - Феодосия - Коктебель - Тополевка - Белогорск.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Симферополь","Бахчисарай", "Севастополь", "Балаклава", "Мисхор", "Гаспра", "Никита","Алушта", "Судак", "Феодосия", "Коктебель", "Белогорск" },
        periodStart = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 39800.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/87312b57-8648-4145-a331-8c1c2de2933e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_87312b57-8648-4145-a331-8c1c2de2933e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/afa0865f-a214-4111-a7b0-7fd37ff04925.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_afa0865f-a214-4111-a7b0-7fd37ff04925.jpeg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ca3bb33c-8782-4725-83c2-cd155c6f2eac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ca3bb33c-8782-4725-83c2-cd155c6f2eac.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b6f7750e-d3bd-4f2f-b55e-c61f2bae9196.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b6f7750e-d3bd-4f2f-b55e-c61f2bae9196.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/e3a36c67-ed83-4a6e-85f1-59467a16c8d0.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_e3a36c67-ed83-4a6e-85f1-59467a16c8d0.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fb244bf7-ddff-4d6a-aacb-a02604e53860.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fb244bf7-ddff-4d6a-aacb-a02604e53860.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/621276bb-5b5c-4287-9602-eb275ced1817.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_621276bb-5b5c-4287-9602-eb275ced1817.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/0f4cf21b-83da-4db0-a071-1c9f674cae4d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_0f4cf21b-83da-4db0-a071-1c9f674cae4d.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a0772923-cece-42dd-aabb-1de971a48f11.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a0772923-cece-42dd-aabb-1de971a48f11.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/87312b57-8648-4145-a331-8c1c2de2933e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_87312b57-8648-4145-a331-8c1c2de2933e.jpg"
            }
            }
            },
                        new Product
            {
        id = 91,
        title = "Золотое кольцо, 5 дней (вариант 3)",
        header = "Тур по Золотому кольцу России из Санкт-Петербурга по маршруту: Переславль-Залесский – Ростов Великий – Углич – Мышкин –  Ярославль – Кострома – Плес – Иваново – Владимир – Суздаль с теплоходной экскурсией по Волге. Большое Золотое кольцо.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Переславль-Залесский", "Ростов Великий", "Углич", "Мышкин", "Ярославль",  "Кострома", "Плёс", "Иваново", "Владимир", "Суздаль" },
        periodStart = new DateTimeOffset(2019, 5, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 5, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 37980.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/98b3ef81-ff54-47d4-a0de-926721d067b9.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_98b3ef81-ff54-47d4-a0de-926721d067b9.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5d056cfb-e0cc-4089-9d46-dd5b640a581d.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5d056cfb-e0cc-4089-9d46-dd5b640a581d.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c967bf00-324d-4d92-89e1-d8b042416293.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c967bf00-324d-4d92-89e1-d8b042416293.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/31c4883e-22d7-4cf9-8881-3d0aed9ac0ad.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_31c4883e-22d7-4cf9-8881-3d0aed9ac0ad.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5864f287-2dd2-4483-8c40-f028445e89a7.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5864f287-2dd2-4483-8c40-f028445e89a7.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3ff57856-796e-4f80-82df-324d2a0f91fd.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3ff57856-796e-4f80-82df-324d2a0f91fd.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/499b10d4-2ecc-42af-b10e-31169e7c99fd.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_499b10d4-2ecc-42af-b10e-31169e7c99fd.jpeg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9b50fdcb-092b-4a1c-a3a2-2af2bab891ac.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9b50fdcb-092b-4a1c-a3a2-2af2bab891ac.jpg"
            }
            }
            },

                    new Product
            {
        id = 92,
        title = "Крымская кругосветка, 5 дней",
        header = "Экскурсионный тур в Крым из Санкт-Петербурга по маршруту: Симферополь - Белогорск - Феодосия - Судак - Новый Свет - Коктебель - Гурзуф - Никита - Массандра - Алупка - Гаспра - Ливадия - Севастополь.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Симферополь", "Белогорск", "Феодосия", "Судак", "Новый Свет",  "Коктебель", "Гурзуф", "Никита", "Массандра", "Алупка", "Гаспра", "Ливадия", "Севастополь" },
        periodStart = new DateTimeOffset(2019, 3, 25, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 31800.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/77e8d3c3-30f1-4459-9297-6601400af104.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_77e8d3c3-30f1-4459-9297-6601400af104.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/afa0865f-a214-4111-a7b0-7fd37ff04925.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_afa0865f-a214-4111-a7b0-7fd37ff04925.jpeg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/4807900b-d7cb-4d4c-be4c-b372ea6c31eb.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_4807900b-d7cb-4d4c-be4c-b372ea6c31eb.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/c5c144b8-867d-4885-8c04-ca247379efca.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_c5c144b8-867d-4885-8c04-ca247379efca.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/29449960-d076-4369-93dc-0959b4c01199.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_29449960-d076-4369-93dc-0959b4c01199.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/eb0108d5-d110-4513-961b-a7980bec8c89.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_eb0108d5-d110-4513-961b-a7980bec8c89.jpg"
            }
            }
            },

                new Product
            {
        id = 93,
        title = "Музыка Фьордов",
        header = "Экскурсионный тур в Норвегию с посещением ледника Бриксдаль и водопада Верингфоссен из  Санкт-Петербурга по маршруту:  Хельсинки – Турку – Стокгольм – Берген – Согнефьорд – ледник Бриксдаль – Гейрангерфьорд – Олесунн – Осло –  Стокгольм  – Турку – Хельсинки – Санкт - Петербург.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Хельсинки", "Турку", "Стокгольм", "Флом", "Берген", "Согнефьорд", "Ледник Бриксдаль", "Гейрангерфьорд", "Олесунн", "Осло" },
        periodStart = new DateTimeOffset(2019, 5, 21, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 5, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 49373.46,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b0a1e9c8-6525-4245-923f-246616f8b773.jpeg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b0a1e9c8-6525-4245-923f-246616f8b773.jpeg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"
            }
            }
            },

                    new Product
            {
        id = 94,
        title = "Жемчужины Европы, 9 дней (вариант эконом)",
        header = "Экскурсионный тур  во Францию через Финляндию, Швецию, Голландию и Бельгию из Санкт-Петербурга по маршруту: Хельсинки - Турку - Стокгольм - Амстердам -  Париж - Брюссель - Гамбург - Стокгольм - Турку. (1 ночной переезд) ",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {   "Хельсинки", "Турку", "Стокгольм", "Треллеборг", "Росток", "Засниц", "Амстердам", "Париж", "Диснейленд Париж","Брюссель", "Гамбург"},
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 24495.36,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/706a1edd-d7a9-4866-a6b3-47e2a3bfe3a8.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_706a1edd-d7a9-4866-a6b3-47e2a3bfe3a8.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/74210e94-0c24-4640-8a3b-9f6215a13811.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_74210e94-0c24-4640-8a3b-9f6215a13811.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/7f222cbc-0f30-40be-b67e-519d0f77254e.JPG",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_7f222cbc-0f30-40be-b67e-519d0f77254e.JPG"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_8e4720f2-1efa-4089-8b34-1cf644730e6e.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_5e8d9e4f-1377-4692-aa25-2aebbba85ec1.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b45e5e8f-868c-412e-9415-0c9d1e9d8cec.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_fbfaa5f0-79f8-4a14-a088-2058b019c132.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d50fa3ce-1ba9-465e-8b9e-bd6ebb772454.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d5927a01-ba1c-4c9b-a9d7-8f8e3ee5b701.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b986babf-cb5f-4002-8221-2355a5980af4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b986babf-cb5f-4002-8221-2355a5980af4.jpg"
            }
            }
            },

                        new Product
            {
        id = 95,
        title = "Губернские зарисовки",
        header = "Экскурсионный тур в Калугу, Тулу и Ясную Поляну из Санкт-Петербурга по маршруту: Полотняный завод - Калуга - Тула - Ясная Поляна.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Полотняный Завод", "Калуга", "Тула", "Ясная Поляна" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 24, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 15714.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f2ab4af0-6247-4eb8-8ab8-b9220da9a90e.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f2ab4af0-6247-4eb8-8ab8-b9220da9a90e.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/b0f6d65f-00c9-4419-86df-7fe8cb08103f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_b0f6d65f-00c9-4419-86df-7fe8cb08103f.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f8327726-d0cb-42bd-a9f4-9543142489d4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f8327726-d0cb-42bd-a9f4-9543142489d4.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/356e0973-e6f2-4371-98a7-670f7a8fc475.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_356e0973-e6f2-4371-98a7-670f7a8fc475.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/db131393-24f5-474a-99fb-b73d7dfaa161.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_db131393-24f5-474a-99fb-b73d7dfaa161.jpg"
            }
            }
            },

                            new Product
            {
        id = 96,
        title = "Итальянские каникулы",
        header = "Экскурсионный автобусный тур в Италию из Санкт-Петербурга без ночных автобусных переездов по маршруту: Каунас/Вильнюс - Варшава - Вена - Верона - Рим - Флоренция - Венеция - Грац .",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Вильнюс", "Каунас", "Варшава", "Вена", "Верона", "Рим", "Флоренция", "Венеция", "Грац" },
        periodStart = new DateTimeOffset(2019, 3, 23, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 1, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 76580.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f840a12e-a45f-4f7c-8f29-0b98ed6a8ffa.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f840a12e-a45f-4f7c-8f29-0b98ed6a8ffa.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3faa76eb-41fd-4060-be43-a59f246d490a.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3faa76eb-41fd-4060-be43-a59f246d490a.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/66b8008a-49f9-48a6-b133-7b47efec15c2.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_66b8008a-49f9-48a6-b133-7b47efec15c2.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/84b708df-ce4d-406c-b2ca-f1d1a9946d40.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_84b708df-ce4d-406c-b2ca-f1d1a9946d40.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/95a909c4-32bd-4ed9-bd36-2845d8314320.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_95a909c4-32bd-4ed9-bd36-2845d8314320.jpg"
            }
            }
            },

                new Product
            {
        id = 97,
        title = "Край света. Путешествие к самой северной точке Европы - мысу Нордкап",
        header = "Экскурсионный тур в Норвегию на лето 2019 года из Санкт-Петербурга по маршруту: Оулу - Кеми - Торнио - Хапарандой - Килписъярви - Тромсё - Хаммерфест - Мыс Нордкап - Карашок - Инари - Рованиеми - Каяни - Куопио.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Оулу", "Кеми", "Эвертурнео", "Тромсе", "Хаммерфест", "Нордкап", "Рованиеми", "Каяни", "Куопио"},
        periodStart = new DateTimeOffset(2019, 6, 22, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 6, 29, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 124012.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f83ee3e1-2423-4569-be9a-866b7ad362c4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f83ee3e1-2423-4569-be9a-866b7ad362c4.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f946f626-b4db-4df1-82b3-181460021f1f.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f946f626-b4db-4df1-82b3-181460021f1f.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/12044a88-7528-4432-8cbb-9511ba248819.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_12044a88-7528-4432-8cbb-9511ba248819.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a2902ee4-9688-4884-8715-068f022be55b.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a2902ee4-9688-4884-8715-068f022be55b.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f83ee3e1-2423-4569-be9a-866b7ad362c4.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f83ee3e1-2423-4569-be9a-866b7ad362c4.jpg"
            }
            }
            },

                    new Product
            {
        id = 101,
        title = "Белоруссия. Замки, 2 дня (вариант 1)",
        header = "Экскурсионный тур в Белоруссию из Санкт-Петербурга на 2 дня по маршруту: Минск – Несвиж – Мир. Проживание в замковом комплексе Несвижа.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> { "Минск", "Несвиж", "Мир" },
        periodStart = new DateTimeOffset(2019, 4, 6, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 4, 7, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 38000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/37ffa8ae-e17f-4d66-ab5f-686100e86f63.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_37ffa8ae-e17f-4d66-ab5f-686100e86f63.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg"

            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce03b82f-b4e8-4fbf-b2d1-4ba0a1484b71.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce03b82f-b4e8-4fbf-b2d1-4ba0a1484b71.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a2c236bb-c572-482d-90d9-70c79790417c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a2c236bb-c572-482d-90d9-70c79790417c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dd2382fc-d86b-482b-b026-6eab3fcf6aea.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dd2382fc-d86b-482b-b026-6eab3fcf6aea.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f27ca6ca-d95e-41fa-a3bb-426794f0b0b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f27ca6ca-d95e-41fa-a3bb-426794f0b0b5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d6952868-0fbb-4872-8321-00db273489b6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d6952868-0fbb-4872-8321-00db273489b6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d01d3e6-6c20-4d1b-902b-685ab3ded2da.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d01d3e6-6c20-4d1b-902b-685ab3ded2da.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/9456e5d8-fde8-4c8d-9d8c-063e27208f7c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_9456e5d8-fde8-4c8d-9d8c-063e27208f7c.jpg"
            }
            }
            },

                        new Product
            {
        id = 102,
        title = "Белоруссия. Минск, 2 дня",
        header = "Экскурсионный тур в Белоруссию из Санкт-Петербурга на 2 дня по маршруту: Минск – Мир – Несвиж – Дудутки.",
        description = "Идейные соображения высшего порядка, а также постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения соответствующий условий активизации. Не следует, однако забывать, что консультация с широким активом позволяет выполнять важные задания по разработке модели развития.\r\n\r\nЗадача организации,\r\nв особенности же постоянное информационно - пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.Товарищи!дальнейшее развитие различных форм деятельности позволяет оценить значение направлений прогрессивного развития.Значимость этих проблем настолько очевидна,\r\nчто начало повседневной работы по формированию позиции требуют определения и уточнения новых предложений.Равным образом дальнейшее развитие различных форм деятельности позволяет оценить значение систем массового участия.С другой стороны рамки и место обучения кадров требуют от нас анализа соответствующий условий активизации.\r\n\r\nРазнообразный и богатый опыт дальнейшее развитие различных форм деятельности обеспечивает широкому кругу(специалистов) участие в формировании направлений прогрессивного развития.Не следует,\r\nоднако забывать,\r\nчто постоянное информационно - пропагандистское обеспечение нашей деятельности позволяет выполнять важные задания по разработке существенных финансовых и административных условий.",
        route = new List<string> {"Минск", "Мир", "Несвиж", "Дудутки" },
        periodStart = new DateTimeOffset(2019, 3, 16, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        periodEnd = new DateTimeOffset(2019, 3, 17, 0, 00, 00, new TimeSpan(+3, 0, 0)),
        minPrice = 19000.0,
        photoCard = new PhotoCard
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg"
            },
        photoAlbum = new List<PhotoAlbum>
            {
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d16cde1-b6f4-431b-b6c5-28c77c734176.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/ce03b82f-b4e8-4fbf-b2d1-4ba0a1484b71.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_ce03b82f-b4e8-4fbf-b2d1-4ba0a1484b71.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/a2c236bb-c572-482d-90d9-70c79790417c.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_a2c236bb-c572-482d-90d9-70c79790417c.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/dd2382fc-d86b-482b-b026-6eab3fcf6aea.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_dd2382fc-d86b-482b-b026-6eab3fcf6aea.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/f27ca6ca-d95e-41fa-a3bb-426794f0b0b5.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_f27ca6ca-d95e-41fa-a3bb-426794f0b0b5.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/d6952868-0fbb-4872-8321-00db273489b6.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_d6952868-0fbb-4872-8321-00db273489b6.jpg"
            },
            new PhotoAlbum
            {
            photo = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/3d01d3e6-6c20-4d1b-902b-685ab3ded2da.jpg",
            thumbnail = "https://cdn.sozvezdie-tour.ru/images/uploadedfiles/tn_3d01d3e6-6c20-4d1b-902b-685ab3ded2da.jpg"
            }
            }
            },

        };



    

        
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productList;
        }

        
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productList.FirstOrDefault(p => p.id == id);
        }

        }
}
