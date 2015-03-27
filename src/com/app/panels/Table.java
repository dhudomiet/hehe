package com.app.panels;

import java.util.ArrayList;
import java.util.List;

import javax.swing.JPanel;
import javax.swing.JTextField;

import com.app.core.Record;

public class Table extends JPanel {
	
	private List<JTextField[]> records;
	private Record[][] tableRecords;
	private Record[] supplier;
	private Record[] recipient;
	private int width;
	private int height;
	int x = 0;
	int y=0;
	int widthRecord=40;
	int heightRecord = 20;
	
	/**
	 * Create the panel.
	 */
	public Table() {
		this.width = 4;
		this.height = 4;
		this.records = new ArrayList<JTextField[]>();
		initializeRecords();
		addComponents();
	}
	
	public Table(int width, int height){
		this.width = width;
		this.height = height;
		this.records = new ArrayList<JTextField[]>();
		initializeRecords();
		addComponents();
	}
	
	private void initializeRecords(){
		for(int i=0;i<this.height;i++){
			JTextField[] rec = new JTextField[this.width];
			for(int j=0;j<rec.length;j++){
				rec[j] = new JTextField();
			}
			this.records.add(rec);
		}
	}
	
	
	private void addComponents(){
		int x = this.x;
		int y=this.y;
		int widthRecord=this.widthRecord;
		int heightRecord = this.heightRecord;
		for( JTextField[] a : records){
			for(int i=0;i<a.length;i++){
				a[i].setBounds(x, y, widthRecord, heightRecord);
				this.add(a[i]);
				x+=40;
			}
			x=this.x;
			y+=20;
		}
	}
	
	public void initializeTableRecords(){
		this.tableRecords = new Record[this.height-1][this.width-1];
		for(int i=0;i<this.height-1;i++){
			for(int j=0;j<this.width-1;j++){
				this.tableRecords[i][j]= new Record();
				this.tableRecords[i][j].setI(i);
				this.tableRecords[i][j].setJ(j);
				this.tableRecords[i][j].setValue(Integer.parseInt(this.records.get(i+1)[j+1].getText()));
			}
		}
		this.supplier = new Record[this.height-1];
		this.recipient = new Record[this.width-1];
		for(int i=0;i<this.height-1;i++){
			this.supplier[i] = new Record();
			this.supplier[i].setI(i);
			this.supplier[i].setValue(Integer.parseInt(this.records.get(i+1)[0].getText()));
		}
		
		for(int i=0;i<this.width-1;i++){
			this.recipient[i] = new Record();
			this.recipient[i].setI(i);
			this.recipient[i].setValue(Integer.parseInt(this.records.get(0)[i+1].getText()));
		}
		
	}

}
