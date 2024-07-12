import React, { useState } from 'react';

const Assistant = ({ platformCss, platformName }) => {
  const [messages, setMessages] = useState([
    {
      type: 'bot',
      text: "Hi, I'm the Cymbal Shops assistant. I can help you with your shopping experience."
    },
    {
      type: 'bot',
      text: 'What can I help you with?'
    }
  ]);
  const [inputValue, setInputValue] = useState('');
  const [image, setImage] = useState(null);

  const handleInputChange = (e) => {
    setInputValue(e.target.value);
  };

  const handleFileChange = (e) => {
    const file = e.target.files[0];
    const reader = new FileReader();
    reader.onloadend = () => {
      setImage(reader.result);
    };
    reader.readAsDataURL(file);
  };

  const handleButtonClick = async () => {
    if (!inputValue.trim()) {
      return;
    }

    const newMessage = {
      type: 'user',
      text: inputValue,
      image: image
    };
    setMessages([...messages, newMessage]);
    setInputValue('');
    setImage(null);

    const response = await fetch('/bot', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        message: newMessage.text,
        image: newMessage.image
      }),
    });

    const responseJson = await response.json();

    const botMessage = {
      type: 'bot',
      text: responseJson.message.replace(/\n+[-*\d][\S\s]*/g, '')
    };

    setMessages([...messages, newMessage, botMessage]);
  };

  return (
    <div>
      <div className={platformCss}>
        <span className="platform-flag">{platformName}</span>
      </div>
      <main role="main">
        <div className="container">
          <div className="row">
            <div className="col-md-12">
              <div id="chat-modal" className="chat-modal">
                <div id="bot-messages" className="bot-messages">
                  {messages.map((message, index) => (
                    <p key={index} className={`${message.type}-message`}>
                      <span className={`${message.type}-message-text`}>{message.text}</span>
                      {message.image && (
                        <div className="user-image-div">
                          <img src={message.image} className="user-image" alt="User Upload" onError={(e) => { e.target.style.display = 'none'; }} />
                        </div>
                      )}
                    </p>
                  ))}
                </div>
                <div className="bot-input">
                  <input
                    id="bot-input-text"
                    type="text"
                    style={{ marginRight: '30px' }}
                    className="bot-input-text"
                    placeholder="Recommend me items..."
                    value={inputValue}
                    onChange={handleInputChange}
                    onKeyPress={(e) => {
                      if (e.key === 'Enter') {
                        handleButtonClick();
                      }
                    }}
                  />
                  <input type="file" className="bot-input-file-button" onChange={handleFileChange} />
                  <button id="bot-input-button" className="bot-input-button" onClick={handleButtonClick}>
                    Send
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </main>
    </div>
  );
};

export default Assistant;
