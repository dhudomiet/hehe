package com.app.frames;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextField;

import com.app.panels.Table;

public class Run extends JFrame implements ActionListener {

	

	/**
	 * 
	 */
	private static final long serialVersionUID = 2L;

	/**
	 * Launch the application.
	 */
	private Table table;
	private JButton generateTable;
	private JTextField chooseWidthTable;
	private JTextField chooseHeightTable;
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Run frame = new Run();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Run() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(0, 0, 700, 600);
		getContentPane().setLayout(null);
		this.chooseWidthTable = new JTextField();
		Label chooseWidthTableLabel = new Label("Podaj iloœæ kolumn tabeli");
		chooseWidthTableLabel.setBounds(0, 0, 173, 20);
		getContentPane().add(chooseWidthTableLabel);
		this.chooseWidthTable.setBounds(191, 0, 40, 20);
		getContentPane().add(chooseWidthTable);
		Label chooseHeightTableLabel = new Label("Podaj iloœæ wierszy tabeli");
		chooseHeightTableLabel.setBounds(0, 26, 173, 20);
		getContentPane().add(chooseHeightTableLabel, BorderLayout.NORTH);
		this.chooseHeightTable = new JTextField();
		this.chooseHeightTable.setBounds(191, 26, 40, 20);
		getContentPane().add(this.chooseHeightTable);
		this.generateTable = new JButton("Generuj Tabele");
		this.generateTable.setBounds(66,47,122,20);
		getContentPane().add(this.generateTable);
		this.generateTable.addActionListener(this);
	}

	public void actionPerformed(ActionEvent e) {
		Object source = e.getSource();
		
		if(source == this.generateTable){
			int width = Integer.parseInt(this.chooseWidthTable.getText());
			int height = Integer.parseInt(this.chooseHeightTable.getText());
			table = new Table(width,height);
			table.setBounds(300,0,500,500);
			this.getContentPane().add(table);
			this.update(this.getGraphics());
		}
		String af= "adasd";	
	}
}
